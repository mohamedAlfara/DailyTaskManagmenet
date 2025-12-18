namespace DailyManagmenet
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDashboardTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelTotalTasks = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTotalTasks = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelSumHours = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSumTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSumHours = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelColumnChart = new Guna.UI2.WinForms.Guna2Panel();
            this.panelColumnChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblColumnTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelRightDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbCompletedTasks = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbNotCompletedTasks = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNotCompletedCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCompletedCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCompletedTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNotCompletedTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelPieChart = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPieChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPieTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelLeftDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbMinTask = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaxHours = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMinHours = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaxTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbMaxTask = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMinTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblToday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnDailyTasks = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            this.panelTotalTasks.SuspendLayout();
            this.panelSumHours.SuspendLayout();
            this.panelColumnChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelColumnChart1)).BeginInit();
            this.panelRightDetails.SuspendLayout();
            this.panelPieChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPieChart1)).BeginInit();
            this.panelLeftDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.BorderRadius = 12;
            this.panelHeader.BorderThickness = 1;
            this.panelHeader.Controls.Add(this.lblDashboardTitle);
            this.panelHeader.Location = new System.Drawing.Point(391, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ShadowDecoration.BorderRadius = 12;
            this.panelHeader.ShadowDecoration.Depth = 5;
            this.panelHeader.ShadowDecoration.Enabled = true;
            this.panelHeader.Size = new System.Drawing.Size(474, 82);
            this.panelHeader.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = false;
            this.lblDashboardTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(474, 82);
            this.lblDashboardTitle.TabIndex = 2;
            this.lblDashboardTitle.Text = "Dashboard";
            this.lblDashboardTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTotalTasks
            // 
            this.panelTotalTasks.BackColor = System.Drawing.Color.Transparent;
            this.panelTotalTasks.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelTotalTasks.BorderRadius = 12;
            this.panelTotalTasks.BorderThickness = 1;
            this.panelTotalTasks.Controls.Add(this.txtTotalTasks);
            this.panelTotalTasks.Controls.Add(this.lblTotalTitle);
            this.panelTotalTasks.Location = new System.Drawing.Point(76, 130);
            this.panelTotalTasks.Name = "panelTotalTasks";
            this.panelTotalTasks.ShadowDecoration.BorderRadius = 12;
            this.panelTotalTasks.ShadowDecoration.Depth = 5;
            this.panelTotalTasks.ShadowDecoration.Enabled = true;
            this.panelTotalTasks.Size = new System.Drawing.Size(533, 79);
            this.panelTotalTasks.TabIndex = 1;
            // 
            // txtTotalTasks
            // 
            this.txtTotalTasks.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtTotalTasks.BorderRadius = 10;
            this.txtTotalTasks.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalTasks.DefaultText = "00";
            this.txtTotalTasks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalTasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalTasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalTasks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalTasks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalTasks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTasks.ForeColor = System.Drawing.Color.Black;
            this.txtTotalTasks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalTasks.Location = new System.Drawing.Point(203, 30);
            this.txtTotalTasks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTotalTasks.Name = "txtTotalTasks";
            this.txtTotalTasks.PlaceholderText = "";
            this.txtTotalTasks.ReadOnly = true;
            this.txtTotalTasks.SelectedText = "";
            this.txtTotalTasks.ShortcutsEnabled = false;
            this.txtTotalTasks.Size = new System.Drawing.Size(138, 26);
            this.txtTotalTasks.TabIndex = 7;
            this.txtTotalTasks.TabStop = false;
            this.txtTotalTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = false;
            this.lblTotalTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(533, 22);
            this.lblTotalTitle.TabIndex = 3;
            this.lblTotalTitle.Text = "Total Tasks";
            this.lblTotalTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelSumHours
            // 
            this.panelSumHours.BackColor = System.Drawing.Color.Transparent;
            this.panelSumHours.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelSumHours.BorderRadius = 12;
            this.panelSumHours.BorderThickness = 1;
            this.panelSumHours.Controls.Add(this.lblSumTitle);
            this.panelSumHours.Controls.Add(this.txtSumHours);
            this.panelSumHours.Location = new System.Drawing.Point(658, 130);
            this.panelSumHours.Name = "panelSumHours";
            this.panelSumHours.ShadowDecoration.BorderRadius = 12;
            this.panelSumHours.ShadowDecoration.Depth = 5;
            this.panelSumHours.ShadowDecoration.Enabled = true;
            this.panelSumHours.Size = new System.Drawing.Size(533, 79);
            this.panelSumHours.TabIndex = 1;
            // 
            // lblSumTitle
            // 
            this.lblSumTitle.AutoSize = false;
            this.lblSumTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSumTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSumTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSumTitle.Name = "lblSumTitle";
            this.lblSumTitle.Size = new System.Drawing.Size(533, 22);
            this.lblSumTitle.TabIndex = 4;
            this.lblSumTitle.Text = "Sum Hours";
            this.lblSumTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSumHours
            // 
            this.txtSumHours.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtSumHours.BorderRadius = 10;
            this.txtSumHours.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSumHours.DefaultText = "00";
            this.txtSumHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSumHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSumHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSumHours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSumHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSumHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumHours.ForeColor = System.Drawing.Color.Black;
            this.txtSumHours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSumHours.Location = new System.Drawing.Point(190, 30);
            this.txtSumHours.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSumHours.Name = "txtSumHours";
            this.txtSumHours.PlaceholderText = "";
            this.txtSumHours.ReadOnly = true;
            this.txtSumHours.SelectedText = "";
            this.txtSumHours.ShortcutsEnabled = false;
            this.txtSumHours.Size = new System.Drawing.Size(138, 26);
            this.txtSumHours.TabIndex = 5;
            this.txtSumHours.TabStop = false;
            this.txtSumHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelColumnChart
            // 
            this.panelColumnChart.BackColor = System.Drawing.Color.Transparent;
            this.panelColumnChart.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelColumnChart.BorderRadius = 12;
            this.panelColumnChart.BorderThickness = 1;
            this.panelColumnChart.Controls.Add(this.panelColumnChart1);
            this.panelColumnChart.Controls.Add(this.lblColumnTitle);
            this.panelColumnChart.Location = new System.Drawing.Point(658, 232);
            this.panelColumnChart.Name = "panelColumnChart";
            this.panelColumnChart.ShadowDecoration.BorderRadius = 12;
            this.panelColumnChart.ShadowDecoration.Depth = 5;
            this.panelColumnChart.ShadowDecoration.Enabled = true;
            this.panelColumnChart.Size = new System.Drawing.Size(536, 210);
            this.panelColumnChart.TabIndex = 1;
            // 
            // panelColumnChart1
            // 
            chartArea3.Name = "ChartArea1";
            this.panelColumnChart1.ChartAreas.Add(chartArea3);
            this.panelColumnChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.panelColumnChart1.Legends.Add(legend3);
            this.panelColumnChart1.Location = new System.Drawing.Point(0, 22);
            this.panelColumnChart1.Name = "panelColumnChart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.panelColumnChart1.Series.Add(series3);
            this.panelColumnChart1.Size = new System.Drawing.Size(536, 188);
            this.panelColumnChart1.TabIndex = 7;
            this.panelColumnChart1.Text = "chart1";
            // 
            // lblColumnTitle
            // 
            this.lblColumnTitle.AutoSize = false;
            this.lblColumnTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblColumnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblColumnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnTitle.Location = new System.Drawing.Point(0, 0);
            this.lblColumnTitle.Name = "lblColumnTitle";
            this.lblColumnTitle.Size = new System.Drawing.Size(536, 22);
            this.lblColumnTitle.TabIndex = 4;
            this.lblColumnTitle.Text = "Completed / Not Completed";
            this.lblColumnTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelRightDetails
            // 
            this.panelRightDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelRightDetails.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelRightDetails.BorderRadius = 12;
            this.panelRightDetails.BorderThickness = 1;
            this.panelRightDetails.Controls.Add(this.cmbCompletedTasks);
            this.panelRightDetails.Controls.Add(this.cmbNotCompletedTasks);
            this.panelRightDetails.Controls.Add(this.txtNotCompletedCount);
            this.panelRightDetails.Controls.Add(this.txtCompletedCount);
            this.panelRightDetails.Controls.Add(this.lblCompletedTitle);
            this.panelRightDetails.Controls.Add(this.lblNotCompletedTitle);
            this.panelRightDetails.Location = new System.Drawing.Point(658, 460);
            this.panelRightDetails.Name = "panelRightDetails";
            this.panelRightDetails.ShadowDecoration.BorderRadius = 12;
            this.panelRightDetails.ShadowDecoration.Depth = 5;
            this.panelRightDetails.ShadowDecoration.Enabled = true;
            this.panelRightDetails.Size = new System.Drawing.Size(536, 244);
            this.panelRightDetails.TabIndex = 1;
            // 
            // cmbCompletedTasks
            // 
            this.cmbCompletedTasks.BackColor = System.Drawing.Color.Transparent;
            this.cmbCompletedTasks.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbCompletedTasks.BorderRadius = 8;
            this.cmbCompletedTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCompletedTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompletedTasks.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCompletedTasks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCompletedTasks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCompletedTasks.ForeColor = System.Drawing.Color.Black;
            this.cmbCompletedTasks.ItemHeight = 30;
            this.cmbCompletedTasks.Location = new System.Drawing.Point(171, 185);
            this.cmbCompletedTasks.Name = "cmbCompletedTasks";
            this.cmbCompletedTasks.Size = new System.Drawing.Size(191, 36);
            this.cmbCompletedTasks.TabIndex = 6;
            this.cmbCompletedTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbNotCompletedTasks
            // 
            this.cmbNotCompletedTasks.BackColor = System.Drawing.Color.Transparent;
            this.cmbNotCompletedTasks.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbNotCompletedTasks.BorderRadius = 8;
            this.cmbNotCompletedTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNotCompletedTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotCompletedTasks.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNotCompletedTasks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNotCompletedTasks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNotCompletedTasks.ForeColor = System.Drawing.Color.Black;
            this.cmbNotCompletedTasks.ItemHeight = 30;
            this.cmbNotCompletedTasks.Location = new System.Drawing.Point(171, 72);
            this.cmbNotCompletedTasks.Name = "cmbNotCompletedTasks";
            this.cmbNotCompletedTasks.Size = new System.Drawing.Size(191, 36);
            this.cmbNotCompletedTasks.TabIndex = 7;
            this.cmbNotCompletedTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNotCompletedCount
            // 
            this.txtNotCompletedCount.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtNotCompletedCount.BorderRadius = 10;
            this.txtNotCompletedCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNotCompletedCount.DefaultText = "00";
            this.txtNotCompletedCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotCompletedCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotCompletedCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotCompletedCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotCompletedCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotCompletedCount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotCompletedCount.ForeColor = System.Drawing.Color.Black;
            this.txtNotCompletedCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotCompletedCount.Location = new System.Drawing.Point(171, 30);
            this.txtNotCompletedCount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNotCompletedCount.Name = "txtNotCompletedCount";
            this.txtNotCompletedCount.PlaceholderText = "";
            this.txtNotCompletedCount.ReadOnly = true;
            this.txtNotCompletedCount.SelectedText = "";
            this.txtNotCompletedCount.ShortcutsEnabled = false;
            this.txtNotCompletedCount.Size = new System.Drawing.Size(191, 26);
            this.txtNotCompletedCount.TabIndex = 7;
            this.txtNotCompletedCount.TabStop = false;
            this.txtNotCompletedCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompletedCount
            // 
            this.txtCompletedCount.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtCompletedCount.BorderRadius = 10;
            this.txtCompletedCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCompletedCount.DefaultText = "00";
            this.txtCompletedCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompletedCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompletedCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompletedCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompletedCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompletedCount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompletedCount.ForeColor = System.Drawing.Color.Black;
            this.txtCompletedCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompletedCount.Location = new System.Drawing.Point(171, 151);
            this.txtCompletedCount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCompletedCount.Name = "txtCompletedCount";
            this.txtCompletedCount.PlaceholderText = "";
            this.txtCompletedCount.ReadOnly = true;
            this.txtCompletedCount.SelectedText = "";
            this.txtCompletedCount.ShortcutsEnabled = false;
            this.txtCompletedCount.Size = new System.Drawing.Size(191, 26);
            this.txtCompletedCount.TabIndex = 6;
            this.txtCompletedCount.TabStop = false;
            this.txtCompletedCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCompletedTitle
            // 
            this.lblCompletedTitle.AutoSize = false;
            this.lblCompletedTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedTitle.Location = new System.Drawing.Point(3, 121);
            this.lblCompletedTitle.Name = "lblCompletedTitle";
            this.lblCompletedTitle.Size = new System.Drawing.Size(530, 22);
            this.lblCompletedTitle.TabIndex = 4;
            this.lblCompletedTitle.Text = "Completed Tasks";
            this.lblCompletedTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNotCompletedTitle
            // 
            this.lblNotCompletedTitle.AutoSize = false;
            this.lblNotCompletedTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNotCompletedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNotCompletedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotCompletedTitle.Location = new System.Drawing.Point(0, 0);
            this.lblNotCompletedTitle.Name = "lblNotCompletedTitle";
            this.lblNotCompletedTitle.Size = new System.Drawing.Size(536, 22);
            this.lblNotCompletedTitle.TabIndex = 5;
            this.lblNotCompletedTitle.Text = "Not Completed Tasks";
            this.lblNotCompletedTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPieChart
            // 
            this.panelPieChart.BackColor = System.Drawing.Color.Transparent;
            this.panelPieChart.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelPieChart.BorderRadius = 12;
            this.panelPieChart.BorderThickness = 1;
            this.panelPieChart.Controls.Add(this.panelPieChart1);
            this.panelPieChart.Controls.Add(this.lblPieTitle);
            this.panelPieChart.Location = new System.Drawing.Point(76, 232);
            this.panelPieChart.Name = "panelPieChart";
            this.panelPieChart.ShadowDecoration.BorderRadius = 12;
            this.panelPieChart.ShadowDecoration.Depth = 5;
            this.panelPieChart.ShadowDecoration.Enabled = true;
            this.panelPieChart.Size = new System.Drawing.Size(536, 210);
            this.panelPieChart.TabIndex = 1;
            // 
            // panelPieChart1
            // 
            this.panelPieChart1.BackColor = System.Drawing.Color.Transparent;
            this.panelPieChart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.panelPieChart1.BorderlineWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.panelPieChart1.ChartAreas.Add(chartArea4);
            this.panelPieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.panelPieChart1.Legends.Add(legend4);
            this.panelPieChart1.Location = new System.Drawing.Point(0, 22);
            this.panelPieChart1.Margin = new System.Windows.Forms.Padding(4);
            this.panelPieChart1.Name = "panelPieChart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.panelPieChart1.Series.Add(series4);
            this.panelPieChart1.Size = new System.Drawing.Size(536, 188);
            this.panelPieChart1.TabIndex = 35;
            this.panelPieChart1.Text = "chart1";
            title2.Name = "Subjects Study Distribution";
            this.panelPieChart1.Titles.Add(title2);
            // 
            // lblPieTitle
            // 
            this.lblPieTitle.AutoSize = false;
            this.lblPieTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPieTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPieTitle.Name = "lblPieTitle";
            this.lblPieTitle.Size = new System.Drawing.Size(536, 22);
            this.lblPieTitle.TabIndex = 4;
            this.lblPieTitle.Text = "Tasks Distribution";
            this.lblPieTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelLeftDetails
            // 
            this.panelLeftDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelLeftDetails.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelLeftDetails.BorderRadius = 12;
            this.panelLeftDetails.BorderThickness = 1;
            this.panelLeftDetails.Controls.Add(this.cmbMinTask);
            this.panelLeftDetails.Controls.Add(this.txtMaxHours);
            this.panelLeftDetails.Controls.Add(this.txtMinHours);
            this.panelLeftDetails.Controls.Add(this.lblMaxTitle);
            this.panelLeftDetails.Controls.Add(this.cmbMaxTask);
            this.panelLeftDetails.Controls.Add(this.lblMinTitle);
            this.panelLeftDetails.Location = new System.Drawing.Point(87, 468);
            this.panelLeftDetails.Name = "panelLeftDetails";
            this.panelLeftDetails.ShadowDecoration.BorderRadius = 12;
            this.panelLeftDetails.ShadowDecoration.Depth = 5;
            this.panelLeftDetails.ShadowDecoration.Enabled = true;
            this.panelLeftDetails.Size = new System.Drawing.Size(525, 236);
            this.panelLeftDetails.TabIndex = 1;
            // 
            // cmbMinTask
            // 
            this.cmbMinTask.BackColor = System.Drawing.Color.Transparent;
            this.cmbMinTask.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbMinTask.BorderRadius = 8;
            this.cmbMinTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMinTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinTask.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMinTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMinTask.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMinTask.ForeColor = System.Drawing.Color.Black;
            this.cmbMinTask.ItemHeight = 30;
            this.cmbMinTask.Location = new System.Drawing.Point(175, 64);
            this.cmbMinTask.Name = "cmbMinTask";
            this.cmbMinTask.Size = new System.Drawing.Size(179, 36);
            this.cmbMinTask.TabIndex = 8;
            this.cmbMinTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxHours
            // 
            this.txtMaxHours.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMaxHours.BorderRadius = 10;
            this.txtMaxHours.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaxHours.DefaultText = "00";
            this.txtMaxHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaxHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaxHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaxHours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaxHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaxHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxHours.ForeColor = System.Drawing.Color.Black;
            this.txtMaxHours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaxHours.Location = new System.Drawing.Point(175, 151);
            this.txtMaxHours.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaxHours.Name = "txtMaxHours";
            this.txtMaxHours.PlaceholderText = "";
            this.txtMaxHours.ReadOnly = true;
            this.txtMaxHours.SelectedText = "";
            this.txtMaxHours.ShortcutsEnabled = false;
            this.txtMaxHours.Size = new System.Drawing.Size(179, 26);
            this.txtMaxHours.TabIndex = 7;
            this.txtMaxHours.TabStop = false;
            this.txtMaxHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinHours
            // 
            this.txtMinHours.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtMinHours.BorderRadius = 10;
            this.txtMinHours.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMinHours.DefaultText = "00";
            this.txtMinHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMinHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMinHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinHours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinHours.ForeColor = System.Drawing.Color.Black;
            this.txtMinHours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinHours.Location = new System.Drawing.Point(175, 30);
            this.txtMinHours.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMinHours.Name = "txtMinHours";
            this.txtMinHours.PlaceholderText = "";
            this.txtMinHours.ReadOnly = true;
            this.txtMinHours.SelectedText = "";
            this.txtMinHours.ShortcutsEnabled = false;
            this.txtMinHours.Size = new System.Drawing.Size(179, 26);
            this.txtMinHours.TabIndex = 6;
            this.txtMinHours.TabStop = false;
            this.txtMinHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaxTitle
            // 
            this.lblMaxTitle.AutoSize = false;
            this.lblMaxTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTitle.Location = new System.Drawing.Point(0, 121);
            this.lblMaxTitle.Name = "lblMaxTitle";
            this.lblMaxTitle.Size = new System.Drawing.Size(522, 22);
            this.lblMaxTitle.TabIndex = 4;
            this.lblMaxTitle.Text = "Max Hours Task";
            this.lblMaxTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbMaxTask
            // 
            this.cmbMaxTask.BackColor = System.Drawing.Color.Transparent;
            this.cmbMaxTask.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbMaxTask.BorderRadius = 8;
            this.cmbMaxTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaxTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaxTask.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMaxTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMaxTask.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMaxTask.ForeColor = System.Drawing.Color.Black;
            this.cmbMaxTask.ItemHeight = 30;
            this.cmbMaxTask.Location = new System.Drawing.Point(175, 185);
            this.cmbMaxTask.Name = "cmbMaxTask";
            this.cmbMaxTask.Size = new System.Drawing.Size(179, 36);
            this.cmbMaxTask.TabIndex = 5;
            this.cmbMaxTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMinTitle
            // 
            this.lblMinTitle.AutoSize = false;
            this.lblMinTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMinTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMinTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMinTitle.Name = "lblMinTitle";
            this.lblMinTitle.Size = new System.Drawing.Size(525, 22);
            this.lblMinTitle.TabIndex = 5;
            this.lblMinTitle.Text = "Min Hours Task";
            this.lblMinTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblToday
            // 
            this.lblToday.BackColor = System.Drawing.Color.Transparent;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.Color.DimGray;
            this.lblToday.Location = new System.Drawing.Point(12, 738);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(130, 20);
            this.lblToday.TabIndex = 4;
            this.lblToday.Text = "Today : 2025-12-17";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(874, 715);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnDailyTasks
            // 
            this.btnDailyTasks.BorderRadius = 10;
            this.btnDailyTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailyTasks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDailyTasks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDailyTasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDailyTasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDailyTasks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyTasks.ForeColor = System.Drawing.Color.White;
            this.btnDailyTasks.Location = new System.Drawing.Point(1018, 715);
            this.btnDailyTasks.Name = "btnDailyTasks";
            this.btnDailyTasks.Size = new System.Drawing.Size(205, 45);
            this.btnDailyTasks.TabIndex = 6;
            this.btnDailyTasks.Text = "Daily Tasks";
            this.btnDailyTasks.Click += new System.EventHandler(this.btnDailyTasks_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1235, 770);
            this.Controls.Add(this.btnDailyTasks);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panelColumnChart);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.panelTotalTasks);
            this.Controls.Add(this.panelSumHours);
            this.Controls.Add(this.panelRightDetails);
            this.Controls.Add(this.panelPieChart);
            this.Controls.Add(this.panelLeftDetails);
            this.Controls.Add(this.panelHeader);
            this.MinimizeBox = false;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForDashboard";
            this.Shown += new System.EventHandler(this.FrmDashboard_Shown);
            this.panelHeader.ResumeLayout(false);
            this.panelTotalTasks.ResumeLayout(false);
            this.panelSumHours.ResumeLayout(false);
            this.panelColumnChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelColumnChart1)).EndInit();
            this.panelRightDetails.ResumeLayout(false);
            this.panelPieChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelPieChart1)).EndInit();
            this.panelLeftDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Panel panelTotalTasks;
        private Guna.UI2.WinForms.Guna2Panel panelSumHours;
        private Guna.UI2.WinForms.Guna2Panel panelColumnChart;
        private Guna.UI2.WinForms.Guna2Panel panelRightDetails;
        private Guna.UI2.WinForms.Guna2Panel panelPieChart;
        private Guna.UI2.WinForms.Guna2Panel panelLeftDetails;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSumTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPieTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDashboardTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblColumnTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCompletedTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNotCompletedTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaxTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMinTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblToday;
        private Guna.UI2.WinForms.Guna2TextBox txtSumHours;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalTasks;
        private Guna.UI2.WinForms.Guna2TextBox txtNotCompletedCount;
        private Guna.UI2.WinForms.Guna2TextBox txtCompletedCount;
        private Guna.UI2.WinForms.Guna2TextBox txtMaxHours;
        private Guna.UI2.WinForms.Guna2TextBox txtMinHours;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMaxTask;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCompletedTasks;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNotCompletedTasks;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMinTask;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnDailyTasks;
        private System.Windows.Forms.DataVisualization.Charting.Chart panelColumnChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart panelPieChart1;
    }
}