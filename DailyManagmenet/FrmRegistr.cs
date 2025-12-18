using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DailyManagmenet
{
    public partial class FrmRegistr : Form
    {  
        // Constructor
        public FrmRegistr()
        {
            InitializeComponent();
        }

 
        // عند تحميل الفورم
        //Events
        private void FrmRegistr_Shown(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (fullName == "" || username == "" || password == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (SQLiteConnection con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();

                using (SQLiteCommand checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Username=@u", con))
                {
                    checkCmd.Parameters.AddWithValue("@u", username);

                    long count = (long)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists!");
                        return;
                    }
                }

                // إدخال المستخدم
                using (SQLiteCommand cmd =
                    new SQLiteCommand("INSERT INTO Users (FullName, Username, Password) VALUES (@f, @u, @p)", con))
                {
                    cmd.Parameters.AddWithValue("@f", fullName);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Account created successfully!");

            
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

            LoadUsers(); // تحديث قائمة المستخدمين
        }

        
        // تحميل المستخدمين في ComboBox

        private void LoadUsers()
        {
            cmbUsers.Items.Clear();

            using (SQLiteConnection con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("SELECT UserID, Username FROM Users", con))
                using (SQLiteDataReader r = cmd.ExecuteReader())//Row by Row
                {
                    while (r.Read())
                    {
                        cmbUsers.Items.Add(new ComboBoxItem
                        {
                            Text = r["Username"].ToString(),
                            Value = Convert.ToInt32(r["UserID"])
                        });
                    }
                }
            }
        }

      
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem == null)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            ComboBoxItem item = (ComboBoxItem)cmbUsers.SelectedItem;
            int userID = item.Value;

            DialogResult dr = MessageBox.Show(
                "This will delete the user and all his tasks.\nAre you sure?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
                return;

            using (SQLiteConnection con = new SQLiteConnection(Database.connectionString))
            {
                con.Open();

                
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Tasks WHERE UserID=@uid", con))
                {
                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.ExecuteNonQuery();
                }

                // حذف المستخدم
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Users WHERE UserID=@uid", con))
                {
                    cmd.Parameters.AddWithValue("@uid", userID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User deleted successfully.");
            LoadUsers();
        }
        private void linkBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Show();
            this.Close();
        }







        // class for value in ComboBox Item
        // Stores display text and value

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
