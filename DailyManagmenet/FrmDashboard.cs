using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using Guna.UI2.WinForms;

namespace DailyManagmenet
{
    public partial class FrmDashboard : Form
    {
        int currentUserID;

        // ===============================
        // Constructor
        // ===============================
        public FrmDashboard(int userID)
        {
            InitializeComponent();
            currentUserID = userID;

            PrepareAllComboBoxes();
        }

        // ===============================
        // Form Shown Event
        // ===============================
        private void FrmDashboard_Shown(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        // ===============================
        // Load Dashboard
        // ===============================
        private void LoadDashboard()
        {
            LoadTodayDate();
            LoadStats();
            LoadColumnChart();
            LoadPieChart();
        }

        // ===============================
        // Today Date
        // ===============================
        private void LoadTodayDate()
        {
            lblToday.Text = "Today : " + DateTime.Today.ToString("yyyy-MM-dd");
        }

        // ===============================
        // Statistics
        // ===============================
        private void LoadStats()
        {
            // Total Tasks
            txtTotalTasks.Text = GetCount("1=1").ToString();

            // Sum Hours
            txtSumHours.Text = GetSumHours().ToString();

            // Completed Tasks
            var completed = GetTasksByStatus(1);
            txtCompletedCount.Text = completed.count.ToString();
            FillCombo(cmbCompletedTasks, completed.names);

            // Not Completed Tasks
            var notCompleted = GetTasksByStatus(0);
            txtNotCompletedCount.Text = notCompleted.count.ToString();
            FillCombo(cmbNotCompletedTasks, notCompleted.names);

            // Max Hours
            var max = GetMaxHoursTask();
            txtMaxHours.Text = max.hours.ToString();
            FillCombo(cmbMaxTask, max.name);

            // Min Hours
            var min = GetMinHoursTask();
            txtMinHours.Text = min.hours.ToString();
            FillCombo(cmbMinTask, min.name);
        }

        // ===============================
        // Prepare ComboBoxes (once)
        // ===============================
        private void PrepareAllComboBoxes()
        {
            PrepareCombo(cmbCompletedTasks, "Show tasks");
            PrepareCombo(cmbNotCompletedTasks, "Show tasks");
            PrepareCombo(cmbMaxTask, "Show task");
            PrepareCombo(cmbMinTask, "Show task");
        }

        private void PrepareCombo(Guna2ComboBox combo, string placeholder)
        {
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.Items.Clear();
            combo.Items.Add(placeholder);
            combo.SelectedIndex = 0;
        }

        // ===============================
        // Fill ComboBox with names
        // ===============================
        private void FillCombo(Guna2ComboBox combo, string names)
        {
            combo.Items.Clear();

            if (string.IsNullOrWhiteSpace(names) || names == "-")
            {
                combo.Items.Add("-");
                combo.SelectedIndex = 0;
                return;
            }

            string[] arr = names.Split(',');
            foreach (string n in arr)
                combo.Items.Add(n.Trim());

            combo.SelectedIndex = 0;
        }

        // ===============================
        // Database Helpers
        // ===============================
        private int GetCount(string condition)
        {
            using (var con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(
                    $"SELECT COUNT(*) FROM Tasks WHERE UserID=@uid AND {condition}", con))
                {
                    cmd.Parameters.AddWithValue("@uid", currentUserID);
                    object r = cmd.ExecuteScalar();
                    return r != DBNull.Value ? Convert.ToInt32(r) : 0;
                }
            }
        }

        private int GetSumHours()
        {
            using (var con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();
                using (var cmd =
                    new SQLiteCommand("SELECT SUM(Hours) FROM Tasks WHERE UserID=@uid", con))
                {
                    cmd.Parameters.AddWithValue("@uid", currentUserID);
                    object r = cmd.ExecuteScalar();
                    return r != DBNull.Value ? Convert.ToInt32(r) : 0;
                }
            }
        }

        private (string name, int hours) GetMaxHoursTask()
        {
            using (var con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(
                    @"SELECT TaskName, Hours 
                      FROM Tasks 
                      WHERE UserID=@uid 
                      ORDER BY Hours DESC 
                      LIMIT 1", con))
                {
                    cmd.Parameters.AddWithValue("@uid", currentUserID);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                            return (r["TaskName"].ToString(),
                                    Convert.ToInt32(r["Hours"]));
                    }
                }
            }
            return ("-", 0);
        }

        private (string name, int hours) GetMinHoursTask()
        {
            using (var con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(
                    @"SELECT TaskName, Hours 
                      FROM Tasks 
                      WHERE UserID=@uid 
                      ORDER BY Hours ASC 
                      LIMIT 1", con))
                {
                    cmd.Parameters.AddWithValue("@uid", currentUserID);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                            return (r["TaskName"].ToString(),
                                    Convert.ToInt32(r["Hours"]));
                    }
                }
            }
            return ("-", 0);
        }

        private (int count, string names) GetTasksByStatus(int status)
        {
            using (var con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(
                    "SELECT TaskName FROM Tasks WHERE UserID=@uid AND Status=@st", con))
                {
                    cmd.Parameters.AddWithValue("@uid", currentUserID);
                    cmd.Parameters.AddWithValue("@st", status);

                    using (var r = cmd.ExecuteReader())
                    {
                        List<string> list = new List<string>();
                        while (r.Read())
                            list.Add(r["TaskName"].ToString());

                        string names = list.Count > 0
                            ? string.Join(", ", list)
                            : "-";

                        return (list.Count, names);
                    }
                }
            }
        }

        // ===============================
        // Column Chart// panelColumnChart1
        // ===============================
        private void LoadColumnChart()
        {
            panelColumnChart1.Series.Clear();
            panelColumnChart1.ChartAreas.Clear();
            panelColumnChart1.Titles.Clear();

            // === الخلفية ===
            panelColumnChart1.BackColor = Color.Transparent;
            panelColumnChart1.BorderlineWidth = 0;

            // === Chart Area ===
            ChartArea area = new ChartArea("Main");

            area.BackColor = Color.Transparent;

            // تقليل البياض
            area.Position = new ElementPosition(10, 18, 80, 65);
            area.InnerPlotPosition = new ElementPosition(15, 15, 70, 70);

            // المحاور
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            area.AxisX.LineColor = Color.Gray;
            area.AxisY.LineColor = Color.Gray;

            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            area.AxisY.Minimum = 0;
            area.AxisX.Interval = 1;

            panelColumnChart1.ChartAreas.Add(area);

            // === Series ===
            Series s = new Series("Tasks");
            s.ChartType = SeriesChartType.Column;

            s.Color = Color.FromArgb(66, 133, 244); // أزرق نظيف
            s["PointWidth"] = "0.3";               // أعمدة رفيعة
            s.IsValueShownAsLabel = true;
            s.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            s.Points.AddXY("Completed", GetCount("Status = 1"));
            s.Points.AddXY("Not Completed", GetCount("Status = 0"));

            panelColumnChart1.Series.Add(s);

          
            

            // === إخفاء الليجند ===
            panelColumnChart1.Legends[0].Enabled = false;
        }


        // ===============================
        // Pie Chart
        // ===============================
        private void LoadPieChart()
        {
            panelPieChart1.Series.Clear();
            panelPieChart1.Titles.Clear();

            Series s = new Series("Tasks");
            s.ChartType = SeriesChartType.Pie;

            // ❌ إخفاء النص داخل الدائرة
            s.IsValueShownAsLabel = false;
            s.Label = "";

            using (var con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(
                    "SELECT TaskName, Color, Hours FROM Tasks WHERE UserID=@uid", con))
                {
                    cmd.Parameters.AddWithValue("@uid", currentUserID);

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string task = r["TaskName"].ToString();
                            int hours = Convert.ToInt32(r["Hours"]);
                            string colorHex = r["Color"].ToString();

                            DataPoint p = new DataPoint();
                            p.YValues = new double[] { hours };

                            // الاسم يظهر فقط في الـ Legend
                            p.LegendText = task;
                            p.ToolTip = $"{task} - {hours} hours";

                            try
                            {
                                p.Color = ColorTranslator.FromHtml(colorHex);
                            }
                            catch
                            {
                                p.Color = Color.Gray;
                            }

                            s.Points.Add(p);
                        }
                    }
                }
            }

            panelPieChart1.Series.Add(s);

            

            // Legend
            panelPieChart1.Legends[0].Enabled = true;
            panelPieChart1.Legends[0].Docking = Docking.Right;
        }


        // ===============================
        // Buttons
        // ===============================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Show();
            this.Close();
        }

        private void btnDailyTasks_Click(object sender, EventArgs e)
        {
            DailyTasks f = new DailyTasks(currentUserID);
            f.Show();
            this.Close();
        }
    }
}
