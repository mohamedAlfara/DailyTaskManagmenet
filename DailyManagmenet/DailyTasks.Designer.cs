namespace DailyManagmenet
{
    partial class DailyTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMarkNotDone = new Guna.UI2.WinForms.Guna2Button();
            this.btnMarkComplete = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lvTasks = new System.Windows.Forms.ListView();
            this.colTaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 12;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(22, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 45);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+ Add Task";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 12;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Gray;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(22, 254);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(183, 45);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit Task";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnMarkNotDone
            // 
            this.btnMarkNotDone.BorderRadius = 12;
            this.btnMarkNotDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkNotDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkNotDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkNotDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMarkNotDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMarkNotDone.FillColor = System.Drawing.Color.Gray;
            this.btnMarkNotDone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMarkNotDone.ForeColor = System.Drawing.Color.White;
            this.btnMarkNotDone.Location = new System.Drawing.Point(22, 478);
            this.btnMarkNotDone.Name = "btnMarkNotDone";
            this.btnMarkNotDone.Size = new System.Drawing.Size(183, 45);
            this.btnMarkNotDone.TabIndex = 11;
            this.btnMarkNotDone.Text = "MarkNotDone";
            this.btnMarkNotDone.Click += new System.EventHandler(this.btnMarkNotDone_Click);
            // 
            // btnMarkComplete
            // 
            this.btnMarkComplete.BorderRadius = 12;
            this.btnMarkComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkComplete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkComplete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMarkComplete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMarkComplete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMarkComplete.FillColor = System.Drawing.Color.Gray;
            this.btnMarkComplete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMarkComplete.ForeColor = System.Drawing.Color.White;
            this.btnMarkComplete.Location = new System.Drawing.Point(22, 406);
            this.btnMarkComplete.Name = "btnMarkComplete";
            this.btnMarkComplete.Size = new System.Drawing.Size(183, 45);
            this.btnMarkComplete.TabIndex = 12;
            this.btnMarkComplete.Text = "MarkComplete";
            this.btnMarkComplete.Click += new System.EventHandler(this.btnMarkComplete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 12;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(22, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvTasks
            // 
            this.lvTasks.BackColor = System.Drawing.Color.White;
            this.lvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTaskName,
            this.colStatus,
            this.colNotes,
            this.colColor,
            this.colHours});
            this.lvTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTasks.ForeColor = System.Drawing.Color.Black;
            this.lvTasks.FullRowSelect = true;
            this.lvTasks.GridLines = true;
            this.lvTasks.HideSelection = false;
            this.lvTasks.Location = new System.Drawing.Point(211, 136);
            this.lvTasks.MultiSelect = false;
            this.lvTasks.Name = "lvTasks";
            this.lvTasks.OwnerDraw = true;
            this.lvTasks.Size = new System.Drawing.Size(1046, 470);
            this.lvTasks.TabIndex = 14;
            this.lvTasks.UseCompatibleStateImageBehavior = false;
            this.lvTasks.View = System.Windows.Forms.View.Details;
            this.lvTasks.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvTasks_DrawColumnHeader);
            this.lvTasks.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvTasks_DrawItem);
            this.lvTasks.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvTasks_DrawSubItem);
            // 
            // colTaskName
            // 
            this.colTaskName.Text = "Task Name";
            this.colTaskName.Width = 180;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 80;
            // 
            // colNotes
            // 
            this.colNotes.Text = "Notes";
            this.colNotes.Width = 300;
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            this.colColor.Width = 110;
            // 
            // colHours
            // 
            this.colHours.Text = "Hours";
            this.colHours.Width = 100;
            // 
            // btnOpenDashboard
            // 
            this.btnOpenDashboard.BorderRadius = 12;
            this.btnOpenDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenDashboard.FillColor = System.Drawing.Color.Gray;
            this.btnOpenDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenDashboard.ForeColor = System.Drawing.Color.White;
            this.btnOpenDashboard.Location = new System.Drawing.Point(22, 547);
            this.btnOpenDashboard.Name = "btnOpenDashboard";
            this.btnOpenDashboard.Size = new System.Drawing.Size(183, 45);
            this.btnOpenDashboard.TabIndex = 16;
            this.btnOpenDashboard.Text = "Dashboard";
            this.btnOpenDashboard.Click += new System.EventHandler(this.btnOpenDashboard_Click);
            // 
            // lblProgressText
            // 
            this.lblProgressText.AutoSize = true;
            this.lblProgressText.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressText.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblProgressText.Location = new System.Drawing.Point(1085, 626);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(139, 23);
            this.lblProgressText.TabIndex = 17;
            this.lblProgressText.Text = "00% Completed";
            this.lblProgressText.UseWaitCursor = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(124, 25);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(825, 52);
            this.guna2HtmlLabel1.TabIndex = 37;
            this.guna2HtmlLabel1.Text = "Daily Task Management";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DailyTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 657);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.btnOpenDashboard);
            this.Controls.Add(this.lvTasks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMarkComplete);
            this.Controls.Add(this.btnMarkNotDone);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "DailyTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnMarkNotDone;
        private Guna.UI2.WinForms.Guna2Button btnMarkComplete;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.ListView lvTasks;
        private System.Windows.Forms.ColumnHeader colTaskName;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colNotes;
        private Guna.UI2.WinForms.Guna2Button btnOpenDashboard;
        private System.Windows.Forms.Label lblProgressText;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.ColumnHeader colHours;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}