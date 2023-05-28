namespace DashboardApp
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dashBoard_label = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.lblNumberOfOrders = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRevenueNum = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalProfitNum = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.lblNumberOfproducts = new System.Windows.Forms.Label();
            this.lblNumSuppliers = new System.Windows.Forms.Label();
            this.lblNumberOfSuppliers = new System.Windows.Forms.Label();
            this.lblTotalCounter = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.lblNumberOfCustomers = new System.Windows.Forms.Label();
            this.SS = new System.Windows.Forms.Panel();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.lblProductsUnderstock = new System.Windows.Forms.Label();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            this.panel4.SuspendLayout();
            this.SS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.SuspendLayout();
            // 
            // dashBoard_label
            // 
            this.dashBoard_label.AutoSize = true;
            this.dashBoard_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dashBoard_label.Location = new System.Drawing.Point(21, 10);
            this.dashBoard_label.Name = "dashBoard_label";
            this.dashBoard_label.Size = new System.Drawing.Size(153, 32);
            this.dashBoard_label.TabIndex = 0;
            this.dashBoard_label.Text = "Dashboard";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(227, 15);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(122, 22);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.Value = new System.DateTime(2022, 2, 16, 0, 0, 0, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(368, 15);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 22);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.Value = new System.DateTime(2022, 2, 22, 0, 0, 0, 0);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnThisMonth.Location = new System.Drawing.Point(1088, 14);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(130, 40);
            this.btnThisMonth.TabIndex = 3;
            this.btnThisMonth.Text = "This Month";
            this.btnThisMonth.UseVisualStyleBackColor = false;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnLast30Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLast30Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLast30Days.Location = new System.Drawing.Point(958, 14);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(130, 40);
            this.btnLast30Days.TabIndex = 4;
            this.btnLast30Days.Text = "Last 30 Days";
            this.btnLast30Days.UseVisualStyleBackColor = false;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnToday.Location = new System.Drawing.Point(698, 14);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(130, 40);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLast7Days.Location = new System.Drawing.Point(828, 14);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(130, 40);
            this.btnLast7Days.TabIndex = 6;
            this.btnLast7Days.Text = "Last 7 Days";
            this.btnLast7Days.UseVisualStyleBackColor = false;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnCustomDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustomDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnCustomDate.Location = new System.Drawing.Point(568, 14);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(130, 40);
            this.btnCustomDate.TabIndex = 7;
            this.btnCustomDate.Text = "Custom";
            this.btnCustomDate.UseVisualStyleBackColor = false;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.lblNumOrders);
            this.panel1.Controls.Add(this.lblNumberOfOrders);
            this.panel1.Location = new System.Drawing.Point(27, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 79);
            this.panel1.TabIndex = 9;
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumOrders.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumOrders.Location = new System.Drawing.Point(12, 34);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(97, 29);
            this.lblNumOrders.TabIndex = 11;
            this.lblNumOrders.Text = "100000";
            // 
            // lblNumberOfOrders
            // 
            this.lblNumberOfOrders.AutoSize = true;
            this.lblNumberOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumberOfOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblNumberOfOrders.Location = new System.Drawing.Point(14, 4);
            this.lblNumberOfOrders.Name = "lblNumberOfOrders";
            this.lblNumberOfOrders.Size = new System.Drawing.Size(148, 20);
            this.lblNumberOfOrders.TabIndex = 10;
            this.lblNumberOfOrders.Text = "Number Of Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.lblTotalRevenueNum);
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Location = new System.Drawing.Point(269, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 79);
            this.panel2.TabIndex = 12;
            // 
            // lblTotalRevenueNum
            // 
            this.lblTotalRevenueNum.AutoSize = true;
            this.lblTotalRevenueNum.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRevenueNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRevenueNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalRevenueNum.Location = new System.Drawing.Point(12, 34);
            this.lblTotalRevenueNum.Name = "lblTotalRevenueNum";
            this.lblTotalRevenueNum.Size = new System.Drawing.Size(97, 29);
            this.lblTotalRevenueNum.TabIndex = 11;
            this.lblTotalRevenueNum.Text = "100000";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(13, 4);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(111, 20);
            this.lblTotalRevenue.TabIndex = 10;
            this.lblTotalRevenue.Text = "TotalRevenue";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.lblTotalProfitNum);
            this.panel3.Controls.Add(this.lblTotalProfit);
            this.panel3.Location = new System.Drawing.Point(654, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 79);
            this.panel3.TabIndex = 13;
            // 
            // lblTotalProfitNum
            // 
            this.lblTotalProfitNum.AutoSize = true;
            this.lblTotalProfitNum.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalProfitNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalProfitNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalProfitNum.Location = new System.Drawing.Point(8, 34);
            this.lblTotalProfitNum.Name = "lblTotalProfitNum";
            this.lblTotalProfitNum.Size = new System.Drawing.Size(97, 29);
            this.lblTotalProfitNum.TabIndex = 11;
            this.lblTotalProfitNum.Text = "100000";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalProfit.Location = new System.Drawing.Point(14, 4);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(91, 20);
            this.lblTotalProfit.TabIndex = 10;
            this.lblTotalProfit.Text = "Total Profit";
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend1);
            this.chartGrossRevenue.Location = new System.Drawing.Point(27, 175);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series1);
            this.chartGrossRevenue.Size = new System.Drawing.Size(777, 300);
            this.chartGrossRevenue.TabIndex = 14;
            this.chartGrossRevenue.Text = "chartGrossRevenue";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.ForeColor = System.Drawing.Color.WhiteSmoke;
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            this.chartGrossRevenue.Titles.Add(title1);
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend2);
            this.chartTopProducts.Location = new System.Drawing.Point(821, 175);
            this.chartTopProducts.Name = "chartTopProducts";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopProducts.Series.Add(series2);
            this.chartTopProducts.Size = new System.Drawing.Size(388, 540);
            this.chartTopProducts.TabIndex = 15;
            this.chartTopProducts.Text = "chartTop5Products";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.ForeColor = System.Drawing.Color.WhiteSmoke;
            title2.Name = "Title1";
            title2.Text = "Top 5 Products";
            this.chartTopProducts.Titles.Add(title2);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel4.Controls.Add(this.lblNumProducts);
            this.panel4.Controls.Add(this.lblNumberOfproducts);
            this.panel4.Controls.Add(this.lblNumSuppliers);
            this.panel4.Controls.Add(this.lblNumberOfSuppliers);
            this.panel4.Controls.Add(this.lblTotalCounter);
            this.panel4.Controls.Add(this.lblNumCustomers);
            this.panel4.Controls.Add(this.lblNumberOfCustomers);
            this.panel4.Location = new System.Drawing.Point(27, 495);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 220);
            this.panel4.TabIndex = 16;
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblNumProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumProducts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumProducts.Location = new System.Drawing.Point(12, 171);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(97, 29);
            this.lblNumProducts.TabIndex = 16;
            this.lblNumProducts.Text = "100000";
            // 
            // lblNumberOfproducts
            // 
            this.lblNumberOfproducts.AutoSize = true;
            this.lblNumberOfproducts.Location = new System.Drawing.Point(14, 155);
            this.lblNumberOfproducts.Name = "lblNumberOfproducts";
            this.lblNumberOfproducts.Size = new System.Drawing.Size(127, 16);
            this.lblNumberOfproducts.TabIndex = 15;
            this.lblNumberOfproducts.Text = "Number Of Products";
            // 
            // lblNumSuppliers
            // 
            this.lblNumSuppliers.AutoSize = true;
            this.lblNumSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.lblNumSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumSuppliers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumSuppliers.Location = new System.Drawing.Point(12, 111);
            this.lblNumSuppliers.Name = "lblNumSuppliers";
            this.lblNumSuppliers.Size = new System.Drawing.Size(97, 29);
            this.lblNumSuppliers.TabIndex = 14;
            this.lblNumSuppliers.Text = "100000";
            // 
            // lblNumberOfSuppliers
            // 
            this.lblNumberOfSuppliers.AutoSize = true;
            this.lblNumberOfSuppliers.Location = new System.Drawing.Point(14, 95);
            this.lblNumberOfSuppliers.Name = "lblNumberOfSuppliers";
            this.lblNumberOfSuppliers.Size = new System.Drawing.Size(131, 16);
            this.lblNumberOfSuppliers.TabIndex = 13;
            this.lblNumberOfSuppliers.Text = "Number Of Suppliers";
            // 
            // lblTotalCounter
            // 
            this.lblTotalCounter.AutoSize = true;
            this.lblTotalCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalCounter.Location = new System.Drawing.Point(3, 0);
            this.lblTotalCounter.Name = "lblTotalCounter";
            this.lblTotalCounter.Size = new System.Drawing.Size(158, 29);
            this.lblTotalCounter.TabIndex = 12;
            this.lblTotalCounter.Text = "TotalCounter";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblNumCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumCustomers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumCustomers.Location = new System.Drawing.Point(12, 54);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(97, 29);
            this.lblNumCustomers.TabIndex = 11;
            this.lblNumCustomers.Text = "100000";
            // 
            // lblNumberOfCustomers
            // 
            this.lblNumberOfCustomers.AutoSize = true;
            this.lblNumberOfCustomers.Location = new System.Drawing.Point(14, 38);
            this.lblNumberOfCustomers.Name = "lblNumberOfCustomers";
            this.lblNumberOfCustomers.Size = new System.Drawing.Size(138, 16);
            this.lblNumberOfCustomers.TabIndex = 10;
            this.lblNumberOfCustomers.Text = "Number Of Customers";
            // 
            // SS
            // 
            this.SS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.SS.Controls.Add(this.dgvUnderstock);
            this.SS.Controls.Add(this.lblProductsUnderstock);
            this.SS.Location = new System.Drawing.Point(242, 495);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(562, 220);
            this.SS.TabIndex = 17;
            // 
            // dgvUnderstock
            // 
            this.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderstock.Location = new System.Drawing.Point(8, 38);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.RowHeadersWidth = 51;
            this.dgvUnderstock.RowTemplate.Height = 24;
            this.dgvUnderstock.Size = new System.Drawing.Size(538, 179);
            this.dgvUnderstock.TabIndex = 17;
            // 
            // lblProductsUnderstock
            // 
            this.lblProductsUnderstock.AutoSize = true;
            this.lblProductsUnderstock.BackColor = System.Drawing.Color.Transparent;
            this.lblProductsUnderstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductsUnderstock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductsUnderstock.Location = new System.Drawing.Point(3, 0);
            this.lblProductsUnderstock.Name = "lblProductsUnderstock";
            this.lblProductsUnderstock.Size = new System.Drawing.Size(248, 29);
            this.lblProductsUnderstock.TabIndex = 12;
            this.lblProductsUnderstock.Text = "Products Understock";
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.btnOkCustomDate.FlatAppearance.BorderSize = 0;
            this.btnOkCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOkCustomDate.ForeColor = System.Drawing.Color.Black;
            this.btnOkCustomDate.Image = ((System.Drawing.Image)(resources.GetObject("btnOkCustomDate.Image")));
            this.btnOkCustomDate.Location = new System.Drawing.Point(525, 14);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(43, 40);
            this.btnOkCustomDate.TabIndex = 18;
            this.btnOkCustomDate.UseVisualStyleBackColor = false;
            this.btnOkCustomDate.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1233, 727);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chartGrossRevenue);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dashBoard_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.SS.ResumeLayout(false);
            this.SS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashBoard_label;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label lblNumberOfOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenueNum;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProfitNum;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label lblNumberOfCustomers;
        private System.Windows.Forms.Label lblTotalCounter;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label lblNumberOfproducts;
        private System.Windows.Forms.Label lblNumSuppliers;
        private System.Windows.Forms.Label lblNumberOfSuppliers;
        private System.Windows.Forms.Panel SS;
        private System.Windows.Forms.DataGridView dgvUnderstock;
        private System.Windows.Forms.Label lblProductsUnderstock;
        private System.Windows.Forms.Button btnOkCustomDate;
    }
}

