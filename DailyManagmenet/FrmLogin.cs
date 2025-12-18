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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            using (SQLiteConnection con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();

                string query = @"SELECT UserID, FullName 
                                 FROM Users 
                                 WHERE Username=@u AND Password=@p";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userID = Convert.ToInt32(reader["UserID"]);
                            string fullName = reader["FullName"].ToString();

                            MessageBox.Show("Login successful!");

                            // افتح الواجهة الرئيسية تبع Daily Tasks
                            DailyTasks frm = new DailyTasks(userID);
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error username or password.");
                        }
                    }
                }
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistr login = new FrmRegistr();
            login.Show();
            this.Hide();

        }

    }

}
