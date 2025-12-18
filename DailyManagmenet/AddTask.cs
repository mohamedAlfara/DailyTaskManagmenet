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
    public partial class AddTask : Form
    {
        private int ttaskID = -1;
        public Color selectedColor = ColorTranslator.FromHtml("#CCCCCC");
        int currentUserID;

       
        public AddTask(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
        }

        // Constructor للتعديل
        public AddTask(int taskID, string name, string notes, int hours, string colorHex, int userID)
        {
            InitializeComponent();

            ttaskID = taskID;
            currentUserID = userID;

            txtName.Text = name;
            txtNotes.Text = notes;
            numHours.Value = hours;

            selectedColor = ColorTranslator.FromHtml(colorHex);
            pnlColor.BackColor = selectedColor;

            btnAdd.Text = "Save Changes";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string notes = txtNotes.Text.Trim();
            int hours = (int)numHours.Value;
            string colorHex = ColorTranslator.ToHtml(selectedColor);

            if (name == "")
            {
                MessageBox.Show("Please enter the task name.");
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Database.connectionString))
                {
                    con.Open();

                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                       
                        if (ttaskID == -1)
                        {
                            cmd.CommandText = @"INSERT INTO Tasks (UserID, TaskName, Status, Notes, TaskDate, Hours, Color)
                                                 VALUES (@uid, @name, 0, @notes, @date, @hours, @color)
                                                ";

                            cmd.Parameters.AddWithValue("@uid", currentUserID);
                            cmd.Parameters.AddWithValue("@date", DateTime.Today.ToShortDateString());
                        }

                        else
                        {  
                            cmd.CommandText = @"
                                UPDATE Tasks
                                SET TaskName = @name,
                                    Notes = @notes,
                                    Hours = @hours,
                                    Color = @color
                                WHERE TaskID = @id
                            ";

                            cmd.Parameters.AddWithValue("@id", ttaskID);
                        }

                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@notes", notes);
                        cmd.Parameters.AddWithValue("@hours", hours);
                        cmd.Parameters.AddWithValue("@color", colorHex);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(ttaskID == -1 ? "Task added successfully!" : "Task updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                selectedColor = cd.Color;
                pnlColor.BackColor = selectedColor;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
