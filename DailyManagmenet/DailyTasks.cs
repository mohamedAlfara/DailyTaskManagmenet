using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyManagmenet
{
    public partial class DailyTasks : Form
    {
        private int progressPercent = 0;
        int currentUserID;
       
        public DailyTasks(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
            LoadTasks();
        }
       
        private void LoadTasks()
        {
            try
            {
                lvTasks.Items.Clear();

                using (SQLiteConnection con = new SQLiteConnection(Database.connectionString))
                {
                    con.Open();

                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT TaskID, TaskName, Status, Notes, Color, Hours " +
                                          "FROM Tasks WHERE TaskDate= @day AND UserID = @uid";

                        cmd.Parameters.AddWithValue("@day", DateTime.Today.ToShortDateString());
                        cmd.Parameters.AddWithValue("@uid", currentUserID);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader["TaskName"].ToString();
                                string status = reader["Status"].ToString() == "1" ? "Yes" : "No";
                                string notes = reader["Notes"].ToString();
                                string colorHex = reader["Color"].ToString();
                                string hours = reader["Hours"].ToString();

                                ListViewItem item = new ListViewItem(name);
                                item.SubItems.Add(status);
                                item.SubItems.Add(notes);
                                item.SubItems.Add(colorHex);
                                item.SubItems.Add(hours);
                                try
                                {
                                    Color c = ColorTranslator.FromHtml(colorHex);
                                    item.SubItems[3].BackColor = c; 
                                    item.SubItems[3].ForeColor = c;   // إخفاء النص
                                }
                                catch { }
                                
                                item.Tag = Convert.ToInt32(reader["TaskID"]);

                                lvTasks.Items.Add(item);
                            }
                        }
                    }
                }

                UpdateProgress();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
        }
             
        private void UpdateProgress()
        {
            int total = lvTasks.Items.Count;
            int done = 0;

            foreach (ListViewItem item in lvTasks.Items)
            {
                if (item.SubItems[1].Text == "Yes")
                    done++;
            }

            progressPercent = total == 0 ? 0 : (done * 100) / total;

            lblProgressText.Text = $"{progressPercent}% Completed";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTask f = new AddTask(currentUserID);

            if (f.ShowDialog() == DialogResult.OK)
                LoadTasks();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.");
                return;
            }

            ListViewItem item = lvTasks.SelectedItems[0];

            int id = (int)item.Tag;
            string name = item.SubItems[0].Text;
            string notes = item.SubItems[2].Text;
            int hours = int.Parse(item.SubItems[4].Text);
            string colorHex = item.SubItems[3].Text;

            AddTask f = new AddTask(id, name, notes, hours, colorHex, currentUserID);

            if (f.ShowDialog() == DialogResult.OK)
                LoadTasks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            ListViewItem item = lvTasks.SelectedItems[0];
            int id = (int)item.Tag;

            DialogResult dr = MessageBox.Show(
                "Are you sure?",
                "Delete Task",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
                return;

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Database.connectionString))
                {
                    con.Open();

                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Tasks WHERE TaskID = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadTasks();
                MessageBox.Show("Task deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting: " + ex.Message);
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a task.");
                return;
            }

            int id = (int)lvTasks.SelectedItems[0].Tag;

            UpdateStatus(id, 1);
        }
        //for updating status column method 
        private void UpdateStatus(int id, int status)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Database.connectionString))
                {
                    con.Open();

                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE Tasks SET Status = @s WHERE TaskID = @id";
                        cmd.Parameters.AddWithValue("@s", status);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message);
            }
        }

        private void btnOpenDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard d = new FrmDashboard(currentUserID);
            
            d.Show();
            this.Hide();
        }

        private void btnMarkNotDone_Click(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a task.");
                return;
            }

            int id = (int)lvTasks.SelectedItems[0].Tag;

            UpdateStatus(id, 0);
        }































        private void lvTasks_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvTasks_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

        }

        private void lvTasks_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // لو العمود هو عمود اللون (Color - index = 3)
            if (e.ColumnIndex == 3)
            {
                try
                {
                    Color c = ColorTranslator.FromHtml(e.SubItem.Text);

                    Rectangle r = e.Bounds;
                    r.Inflate(-5, -5); // تصغير المربع

                    using (Brush b = new SolidBrush(c))
                    {
                        e.Graphics.FillRectangle(b, r);
                    }

                    // لا نعرض أي نص
                    return;
                }
                catch
                {
                    // إذا فشل، ارسم النص العادي
                }
            }

            // للعمود العادي
            e.DrawDefault = true;
        }
    }
}
