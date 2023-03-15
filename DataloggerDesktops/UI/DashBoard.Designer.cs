namespace DataloggerDesktops
{
  partial class DashBoard
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.tmrDashBoard = new System.Windows.Forms.Timer(this.components);
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
      this.chartMagFd = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.panel11 = new System.Windows.Forms.Panel();
      this.labelMFD = new System.Windows.Forms.Label();
      this.panelScatter = new System.Windows.Forms.Panel();
      this.label12 = new System.Windows.Forms.Label();
      this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
      this.chartAccoustic = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.panel9 = new System.Windows.Forms.Panel();
      this.label10 = new System.Windows.Forms.Label();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.cpbSpeed = new CircularProgressBar_NET5.CircularProgressBar();
      this.label13 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cbFactory = new System.Windows.Forms.ComboBox();
      this.cbLine = new System.Windows.Forms.ComboBox();
      this.cbDevice = new System.Windows.Forms.ComboBox();
      this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
      this.label5 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cpbTemp = new CircularProgressBar_NET5.CircularProgressBar();
      this.panel6 = new System.Windows.Forms.Panel();
      this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.label14 = new System.Windows.Forms.Label();
      this.chartVibration = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.panelStatus = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
      this.label11 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel13.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartMagFd)).BeginInit();
      this.panel11.SuspendLayout();
      this.panelScatter.SuspendLayout();
      this.tableLayoutPanel12.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartAccoustic)).BeginInit();
      this.panel9.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel9.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      this.tableLayoutPanel7.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel6.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel11.SuspendLayout();
      this.panel7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartVibration)).BeginInit();
      this.panelStatus.SuspendLayout();
      this.tableLayoutPanel10.SuspendLayout();
      this.panel4.SuspendLayout();
      this.tableLayoutPanel8.SuspendLayout();
      this.SuspendLayout();
      // 
      // tmrDashBoard
      // 
      this.tmrDashBoard.Enabled = true;
      this.tmrDashBoard.Interval = 1000;
      this.tmrDashBoard.Tick += new System.EventHandler(this.tmrDashBoard_Tick);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1124, 609);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel4.ColumnCount = 5;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.53131F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.073345F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.55993F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.252236F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.49374F));
      this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel13, 2, 0);
      this.tableLayoutPanel4.Controls.Add(this.panelScatter, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel12, 4, 0);
      this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 415);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(1118, 191);
      this.tableLayoutPanel4.TabIndex = 3;
      // 
      // tableLayoutPanel13
      // 
      this.tableLayoutPanel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel13.ColumnCount = 1;
      this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel13.Controls.Add(this.chartMagFd, 0, 1);
      this.tableLayoutPanel13.Controls.Add(this.panel11, 0, 0);
      this.tableLayoutPanel13.Location = new System.Drawing.Point(211, 3);
      this.tableLayoutPanel13.Name = "tableLayoutPanel13";
      this.tableLayoutPanel13.RowCount = 2;
      this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.36527F));
      this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.63473F));
      this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel13.Size = new System.Drawing.Size(481, 185);
      this.tableLayoutPanel13.TabIndex = 18;
      // 
      // chartMagFd
      // 
      this.chartMagFd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.chartMagFd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.chartMagFd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.chartMagFd.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
      this.chartMagFd.BackSecondaryColor = System.Drawing.Color.White;
      this.chartMagFd.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.chartMagFd.BorderSkin.BorderColor = System.Drawing.Color.Red;
      chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
      chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
      chartArea1.BorderColor = System.Drawing.Color.IndianRed;
      chartArea1.Name = "ChartArea1";
      this.chartMagFd.ChartAreas.Add(chartArea1);
      legend1.BackImageTransparentColor = System.Drawing.Color.White;
      legend1.BackSecondaryColor = System.Drawing.Color.White;
      legend1.BorderColor = System.Drawing.Color.Transparent;
      legend1.Enabled = false;
      legend1.InterlacedRowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      legend1.Name = "Legend1";
      legend1.Position.Auto = false;
      legend1.Position.Height = 15.26316F;
      legend1.Position.Width = 19.43463F;
      legend1.Position.X = 77.56537F;
      legend1.Position.Y = 3F;
      this.chartMagFd.Legends.Add(legend1);
      this.chartMagFd.Location = new System.Drawing.Point(3, 35);
      this.chartMagFd.Name = "chartMagFd";
      this.chartMagFd.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
      series1.BackImage = "19, 33, 73";
      series1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      series1.BorderWidth = 4;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.Color = System.Drawing.Color.Red;
      series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      series1.LabelBackColor = System.Drawing.Color.White;
      series1.LabelBorderColor = System.Drawing.Color.White;
      series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
      series1.LabelForeColor = System.Drawing.Color.White;
      series1.Legend = "Legend1";
      series1.MarkerBorderColor = System.Drawing.Color.BlueViolet;
      series1.MarkerBorderWidth = 2;
      series1.MarkerColor = System.Drawing.Color.Lime;
      series1.MarkerImageTransparentColor = System.Drawing.Color.White;
      series1.MarkerSize = 7;
      series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      series1.Name = "Dữ liệu từ trường";
      this.chartMagFd.Series.Add(series1);
      this.chartMagFd.Size = new System.Drawing.Size(475, 147);
      this.chartMagFd.SuppressExceptions = true;
      this.chartMagFd.TabIndex = 16;
      this.chartMagFd.Text = "chartMagFd";
      // 
      // panel11
      // 
      this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel11.Controls.Add(this.labelMFD);
      this.panel11.Location = new System.Drawing.Point(3, 3);
      this.panel11.Name = "panel11";
      this.panel11.Size = new System.Drawing.Size(475, 26);
      this.panel11.TabIndex = 0;
      // 
      // labelMFD
      // 
      this.labelMFD.AutoSize = true;
      this.labelMFD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.labelMFD.ForeColor = System.Drawing.Color.Transparent;
      this.labelMFD.Location = new System.Drawing.Point(1, -6);
      this.labelMFD.Name = "labelMFD";
      this.labelMFD.Size = new System.Drawing.Size(390, 28);
      this.labelMFD.TabIndex = 11;
      this.labelMFD.Text = "Magnetic Field Data | Dữ liệu từ trường";
      // 
      // panelScatter
      // 
      this.panelScatter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.panelScatter.Controls.Add(this.label12);
      this.panelScatter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelScatter.Location = new System.Drawing.Point(3, 3);
      this.panelScatter.Name = "panelScatter";
      this.panelScatter.Size = new System.Drawing.Size(190, 185);
      this.panelScatter.TabIndex = 15;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label12.ForeColor = System.Drawing.Color.Transparent;
      this.label12.Location = new System.Drawing.Point(3, 3);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(79, 28);
      this.label12.TabIndex = 11;
      this.label12.Text = "Scatter";
      // 
      // tableLayoutPanel12
      // 
      this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel12.ColumnCount = 1;
      this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel12.Controls.Add(this.chartAccoustic, 0, 1);
      this.tableLayoutPanel12.Controls.Add(this.panel9, 0, 0);
      this.tableLayoutPanel12.Location = new System.Drawing.Point(712, 3);
      this.tableLayoutPanel12.Name = "tableLayoutPanel12";
      this.tableLayoutPanel12.RowCount = 2;
      this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.36527F));
      this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.63473F));
      this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel12.Size = new System.Drawing.Size(403, 185);
      this.tableLayoutPanel12.TabIndex = 17;
      // 
      // chartAccoustic
      // 
      this.chartAccoustic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.chartAccoustic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.chartAccoustic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.chartAccoustic.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
      this.chartAccoustic.BackSecondaryColor = System.Drawing.Color.White;
      this.chartAccoustic.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.chartAccoustic.BorderSkin.BorderColor = System.Drawing.Color.Red;
      chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
      chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
      chartArea2.BorderColor = System.Drawing.Color.IndianRed;
      chartArea2.Name = "ChartArea1";
      this.chartAccoustic.ChartAreas.Add(chartArea2);
      legend2.BackImageTransparentColor = System.Drawing.Color.White;
      legend2.BackSecondaryColor = System.Drawing.Color.White;
      legend2.BorderColor = System.Drawing.Color.Transparent;
      legend2.Enabled = false;
      legend2.InterlacedRowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      legend2.Name = "Legend1";
      legend2.Position.Auto = false;
      legend2.Position.Height = 15.26316F;
      legend2.Position.Width = 19.43463F;
      legend2.Position.X = 77.56537F;
      legend2.Position.Y = 3F;
      this.chartAccoustic.Legends.Add(legend2);
      this.chartAccoustic.Location = new System.Drawing.Point(3, 35);
      this.chartAccoustic.Name = "chartAccoustic";
      this.chartAccoustic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
      series2.BackImage = "19, 33, 73";
      series2.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      series2.BorderWidth = 4;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.Color = System.Drawing.Color.Red;
      series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      series2.LabelBackColor = System.Drawing.Color.White;
      series2.LabelBorderColor = System.Drawing.Color.White;
      series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
      series2.LabelForeColor = System.Drawing.Color.White;
      series2.Legend = "Legend1";
      series2.MarkerBorderColor = System.Drawing.Color.BlueViolet;
      series2.MarkerBorderWidth = 2;
      series2.MarkerColor = System.Drawing.Color.Lime;
      series2.MarkerImageTransparentColor = System.Drawing.Color.White;
      series2.MarkerSize = 7;
      series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      series2.Name = "Dữ liệu âm thanh";
      this.chartAccoustic.Series.Add(series2);
      this.chartAccoustic.Size = new System.Drawing.Size(397, 147);
      this.chartAccoustic.SuppressExceptions = true;
      this.chartAccoustic.TabIndex = 15;
      this.chartAccoustic.Text = "chartAccoustic";
      // 
      // panel9
      // 
      this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel9.Controls.Add(this.label10);
      this.panel9.Location = new System.Drawing.Point(3, 3);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(397, 26);
      this.panel9.TabIndex = 0;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label10.ForeColor = System.Drawing.Color.Transparent;
      this.label10.Location = new System.Drawing.Point(-3, -6);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(328, 28);
      this.label10.TabIndex = 11;
      this.label10.Text = "Acoustic Data | Dữ liệu âm thanh";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
      this.tableLayoutPanel2.ColumnCount = 7;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 4, 0);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.panel6, 6, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1118, 190);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // tableLayoutPanel9
      // 
      this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.tableLayoutPanel9.ColumnCount = 1;
      this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel9.Controls.Add(this.panel3, 0, 1);
      this.tableLayoutPanel9.Controls.Add(this.label13, 0, 2);
      this.tableLayoutPanel9.Controls.Add(this.label6, 0, 0);
      this.tableLayoutPanel9.Location = new System.Drawing.Point(597, 3);
      this.tableLayoutPanel9.Name = "tableLayoutPanel9";
      this.tableLayoutPanel9.RowCount = 3;
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel9.Size = new System.Drawing.Size(221, 184);
      this.tableLayoutPanel9.TabIndex = 17;
      // 
      // panel3
      // 
      this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3.Controls.Add(this.cpbSpeed);
      this.panel3.Location = new System.Drawing.Point(3, 33);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(215, 118);
      this.panel3.TabIndex = 12;
      // 
      // cpbSpeed
      // 
      this.cpbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cpbSpeed.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
      this.cpbSpeed.AnimationSpeed = 500;
      this.cpbSpeed.BackColor = System.Drawing.Color.Transparent;
      this.cpbSpeed.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.cpbSpeed.ForeColor = System.Drawing.Color.White;
      this.cpbSpeed.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.cpbSpeed.InnerMargin = 2;
      this.cpbSpeed.InnerWidth = -1;
      this.cpbSpeed.Location = new System.Drawing.Point(31, 3);
      this.cpbSpeed.MarqueeAnimationSpeed = 2000;
      this.cpbSpeed.Name = "cpbSpeed";
      this.cpbSpeed.OuterColor = System.Drawing.Color.Gray;
      this.cpbSpeed.OuterMargin = -5;
      this.cpbSpeed.OuterWidth = 3;
      this.cpbSpeed.ProgressColor = System.Drawing.Color.Blue;
      this.cpbSpeed.ProgressWidth = 10;
      this.cpbSpeed.SecondaryFont = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.cpbSpeed.Size = new System.Drawing.Size(149, 115);
      this.cpbSpeed.StartAngle = 270;
      this.cpbSpeed.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
      this.cpbSpeed.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
      this.cpbSpeed.SubscriptText = "";
      this.cpbSpeed.SuperscriptColor = System.Drawing.Color.White;
      this.cpbSpeed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
      this.cpbSpeed.SuperscriptText = "°C";
      this.cpbSpeed.TabIndex = 1;
      this.cpbSpeed.Text = "68";
      this.cpbSpeed.TextMargin = new System.Windows.Forms.Padding(8, 0, 0, 0);
      this.cpbSpeed.Value = 68;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label13.ForeColor = System.Drawing.Color.Transparent;
      this.label13.Location = new System.Drawing.Point(3, 154);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(0, 28);
      this.label13.TabIndex = 11;
      this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label6.ForeColor = System.Drawing.Color.Transparent;
      this.label6.Location = new System.Drawing.Point(3, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(69, 28);
      this.label6.TabIndex = 13;
      this.label6.Text = "Speed";
      this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.tableLayoutPanel5.ColumnCount = 2;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.47368F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.52632F));
      this.tableLayoutPanel5.Controls.Add(this.label3, 0, 9);
      this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
      this.tableLayoutPanel5.Controls.Add(this.label1, 0, 4);
      this.tableLayoutPanel5.Controls.Add(this.label2, 0, 7);
      this.tableLayoutPanel5.Controls.Add(this.cbFactory, 1, 4);
      this.tableLayoutPanel5.Controls.Add(this.cbLine, 1, 7);
      this.tableLayoutPanel5.Controls.Add(this.cbDevice, 1, 9);
      this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 10;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(336, 184);
      this.tableLayoutPanel5.TabIndex = 14;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.Transparent;
      this.label3.Location = new System.Drawing.Point(3, 173);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(70, 14);
      this.label3.TabIndex = 14;
      this.label3.Text = "Device";
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label4.ForeColor = System.Drawing.Color.Transparent;
      this.label4.Location = new System.Drawing.Point(3, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(93, 57);
      this.label4.TabIndex = 11;
      this.label4.Text = "Device";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.Transparent;
      this.label1.Location = new System.Drawing.Point(3, 69);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 40);
      this.label1.TabIndex = 12;
      this.label1.Text = "Factory";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.Transparent;
      this.label2.Location = new System.Drawing.Point(3, 120);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 28);
      this.label2.TabIndex = 13;
      this.label2.Text = "Line";
      // 
      // cbFactory
      // 
      this.cbFactory.FormattingEnabled = true;
      this.cbFactory.Location = new System.Drawing.Point(102, 72);
      this.cbFactory.Name = "cbFactory";
      this.cbFactory.Size = new System.Drawing.Size(215, 28);
      this.cbFactory.TabIndex = 15;
      this.cbFactory.SelectedValueChanged += new System.EventHandler(this.cbFactory_SelectedValueChanged);
      // 
      // cbLine
      // 
      this.cbLine.FormattingEnabled = true;
      this.cbLine.Location = new System.Drawing.Point(102, 123);
      this.cbLine.Name = "cbLine";
      this.cbLine.Size = new System.Drawing.Size(215, 28);
      this.cbLine.TabIndex = 16;
      this.cbLine.SelectedValueChanged += new System.EventHandler(this.cbLine_SelectedValueChanged_1);
      // 
      // cbDevice
      // 
      this.cbDevice.FormattingEnabled = true;
      this.cbDevice.Location = new System.Drawing.Point(102, 176);
      this.cbDevice.Name = "cbDevice";
      this.cbDevice.Size = new System.Drawing.Size(215, 28);
      this.cbDevice.TabIndex = 17;
      // 
      // tableLayoutPanel7
      // 
      this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.tableLayoutPanel7.ColumnCount = 1;
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
      this.tableLayoutPanel7.Controls.Add(this.panel1, 0, 1);
      this.tableLayoutPanel7.Location = new System.Drawing.Point(355, 3);
      this.tableLayoutPanel7.Name = "tableLayoutPanel7";
      this.tableLayoutPanel7.RowCount = 3;
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel7.Size = new System.Drawing.Size(221, 184);
      this.tableLayoutPanel7.TabIndex = 16;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label5.ForeColor = System.Drawing.Color.Transparent;
      this.label5.Location = new System.Drawing.Point(3, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(132, 28);
      this.label5.TabIndex = 11;
      this.label5.Text = "Temperature";
      this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.cpbTemp);
      this.panel1.Location = new System.Drawing.Point(3, 33);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(215, 118);
      this.panel1.TabIndex = 12;
      // 
      // cpbTemp
      // 
      this.cpbTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cpbTemp.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
      this.cpbTemp.AnimationSpeed = 500;
      this.cpbTemp.BackColor = System.Drawing.Color.Transparent;
      this.cpbTemp.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.cpbTemp.ForeColor = System.Drawing.Color.White;
      this.cpbTemp.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.cpbTemp.InnerMargin = 2;
      this.cpbTemp.InnerWidth = -1;
      this.cpbTemp.Location = new System.Drawing.Point(33, 3);
      this.cpbTemp.MarqueeAnimationSpeed = 2000;
      this.cpbTemp.Name = "cpbTemp";
      this.cpbTemp.OuterColor = System.Drawing.Color.Gray;
      this.cpbTemp.OuterMargin = -5;
      this.cpbTemp.OuterWidth = 3;
      this.cpbTemp.ProgressColor = System.Drawing.Color.Red;
      this.cpbTemp.ProgressWidth = 10;
      this.cpbTemp.SecondaryFont = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.cpbTemp.Size = new System.Drawing.Size(149, 115);
      this.cpbTemp.StartAngle = 270;
      this.cpbTemp.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
      this.cpbTemp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
      this.cpbTemp.SubscriptText = "";
      this.cpbTemp.SuperscriptColor = System.Drawing.Color.White;
      this.cpbTemp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
      this.cpbTemp.SuperscriptText = "°C";
      this.cpbTemp.TabIndex = 0;
      this.cpbTemp.Text = "68";
      this.cpbTemp.TextMargin = new System.Windows.Forms.Padding(8, 0, 0, 0);
      this.cpbTemp.Value = 68;
      // 
      // panel6
      // 
      this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel6.Controls.Add(this.monthCalendar1);
      this.panel6.Location = new System.Drawing.Point(834, 3);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(281, 184);
      this.panel6.TabIndex = 18;
      // 
      // monthCalendar1
      // 
      this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.monthCalendar1.Location = new System.Drawing.Point(9, -11);
      this.monthCalendar1.Name = "monthCalendar1";
      this.monthCalendar1.TabIndex = 1;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel3.ColumnCount = 5;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.62075F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9838998F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.64937F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.2213F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.41101F));
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel11, 4, 0);
      this.tableLayoutPanel3.Controls.Add(this.panelStatus, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel10, 2, 0);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 209);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(1118, 190);
      this.tableLayoutPanel3.TabIndex = 2;
      // 
      // tableLayoutPanel11
      // 
      this.tableLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel11.ColumnCount = 1;
      this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel11.Controls.Add(this.panel7, 0, 0);
      this.tableLayoutPanel11.Controls.Add(this.chartVibration, 0, 1);
      this.tableLayoutPanel11.Location = new System.Drawing.Point(712, 3);
      this.tableLayoutPanel11.Name = "tableLayoutPanel11";
      this.tableLayoutPanel11.RowCount = 2;
      this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.36527F));
      this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.63473F));
      this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel11.Size = new System.Drawing.Size(403, 184);
      this.tableLayoutPanel11.TabIndex = 16;
      // 
      // panel7
      // 
      this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel7.Controls.Add(this.label14);
      this.panel7.Location = new System.Drawing.Point(3, 3);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(397, 25);
      this.panel7.TabIndex = 0;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label14.ForeColor = System.Drawing.Color.Transparent;
      this.label14.Location = new System.Drawing.Point(-3, -6);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(320, 28);
      this.label14.TabIndex = 11;
      this.label14.Text = "Vibration Data | Dữ liệu độ rung";
      // 
      // chartVibration
      // 
      this.chartVibration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.chartVibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.chartVibration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.chartVibration.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
      this.chartVibration.BackSecondaryColor = System.Drawing.Color.White;
      this.chartVibration.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.chartVibration.BorderSkin.BorderColor = System.Drawing.Color.Red;
      chartArea3.Area3DStyle.Enable3D = true;
      chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
      chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
      chartArea3.BorderColor = System.Drawing.Color.IndianRed;
      chartArea3.Name = "ChartArea1";
      this.chartVibration.ChartAreas.Add(chartArea3);
      legend3.BackImageTransparentColor = System.Drawing.Color.White;
      legend3.BackSecondaryColor = System.Drawing.Color.White;
      legend3.BorderColor = System.Drawing.Color.Transparent;
      legend3.Enabled = false;
      legend3.InterlacedRowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      legend3.Name = "Legend1";
      legend3.Position.Auto = false;
      legend3.Position.Height = 15.26316F;
      legend3.Position.Width = 19.43463F;
      legend3.Position.X = 77.56537F;
      legend3.Position.Y = 3F;
      this.chartVibration.Legends.Add(legend3);
      this.chartVibration.Location = new System.Drawing.Point(3, 34);
      this.chartVibration.Name = "chartVibration";
      this.chartVibration.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
      series3.BackImage = "19, 33, 73";
      series3.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      series3.BorderWidth = 4;
      series3.ChartArea = "ChartArea1";
      series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series3.Color = System.Drawing.Color.Red;
      series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      series3.LabelBackColor = System.Drawing.Color.White;
      series3.LabelBorderColor = System.Drawing.Color.White;
      series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
      series3.LabelForeColor = System.Drawing.Color.White;
      series3.Legend = "Legend1";
      series3.MarkerBorderColor = System.Drawing.Color.BlueViolet;
      series3.MarkerBorderWidth = 2;
      series3.MarkerColor = System.Drawing.Color.Lime;
      series3.MarkerImageTransparentColor = System.Drawing.Color.White;
      series3.MarkerSize = 7;
      series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      series3.Name = "Dữ liệu độ rung";
      this.chartVibration.Series.Add(series3);
      this.chartVibration.Size = new System.Drawing.Size(397, 147);
      this.chartVibration.SuppressExceptions = true;
      this.chartVibration.TabIndex = 14;
      this.chartVibration.Text = "chartVibration";
      // 
      // panelStatus
      // 
      this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.panelStatus.Controls.Add(this.label7);
      this.panelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelStatus.Location = new System.Drawing.Point(3, 3);
      this.panelStatus.Name = "panelStatus";
      this.panelStatus.Size = new System.Drawing.Size(191, 184);
      this.panelStatus.TabIndex = 5;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label7.ForeColor = System.Drawing.Color.Transparent;
      this.label7.Location = new System.Drawing.Point(3, 3);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(71, 28);
      this.label7.TabIndex = 11;
      this.label7.Text = "Status";
      // 
      // tableLayoutPanel10
      // 
      this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel10.ColumnCount = 1;
      this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel10.Controls.Add(this.panel5, 0, 1);
      this.tableLayoutPanel10.Controls.Add(this.panel4, 0, 0);
      this.tableLayoutPanel10.Location = new System.Drawing.Point(211, 3);
      this.tableLayoutPanel10.Name = "tableLayoutPanel10";
      this.tableLayoutPanel10.RowCount = 2;
      this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.36527F));
      this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.63473F));
      this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel10.Size = new System.Drawing.Size(482, 184);
      this.tableLayoutPanel10.TabIndex = 15;
      // 
      // panel5
      // 
      this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel5.Location = new System.Drawing.Point(3, 34);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(476, 147);
      this.panel5.TabIndex = 1;
      // 
      // panel4
      // 
      this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel4.Controls.Add(this.label8);
      this.panel4.Location = new System.Drawing.Point(3, 3);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(476, 25);
      this.panel4.TabIndex = 0;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label8.ForeColor = System.Drawing.Color.Transparent;
      this.label8.Location = new System.Drawing.Point(-3, -3);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(238, 28);
      this.label8.TabIndex = 11;
      this.label8.Text = "Trend | Dự đoán dữ liệu";
      // 
      // tableLayoutPanel8
      // 
      this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
      this.tableLayoutPanel8.ColumnCount = 1;
      this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel8.Controls.Add(this.label11, 0, 0);
      this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel8.Name = "tableLayoutPanel8";
      this.tableLayoutPanel8.RowCount = 3;
      this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 100);
      this.tableLayoutPanel8.TabIndex = 0;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label11.ForeColor = System.Drawing.Color.Transparent;
      this.label11.Location = new System.Drawing.Point(3, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(132, 20);
      this.label11.TabIndex = 11;
      this.label11.Text = "Temperature";
      this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // panel2
      // 
      this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel2.Location = new System.Drawing.Point(3, 31);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(194, 1);
      this.panel2.TabIndex = 12;
      // 
      // DashBoard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
      this.ClientSize = new System.Drawing.Size(1148, 633);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "DashBoard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormDashBoard";
      this.Load += new System.EventHandler(this.DashBoard_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel13.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chartMagFd)).EndInit();
      this.panel11.ResumeLayout(false);
      this.panel11.PerformLayout();
      this.panelScatter.ResumeLayout(false);
      this.panelScatter.PerformLayout();
      this.tableLayoutPanel12.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chartAccoustic)).EndInit();
      this.panel9.ResumeLayout(false);
      this.panel9.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel9.ResumeLayout(false);
      this.tableLayoutPanel9.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.tableLayoutPanel5.ResumeLayout(false);
      this.tableLayoutPanel5.PerformLayout();
      this.tableLayoutPanel7.ResumeLayout(false);
      this.tableLayoutPanel7.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel6.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel11.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartVibration)).EndInit();
      this.panelStatus.ResumeLayout(false);
      this.panelStatus.PerformLayout();
      this.tableLayoutPanel10.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.tableLayoutPanel8.ResumeLayout(false);
      this.tableLayoutPanel8.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Timer tmrDashBoard;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Panel panelStatus;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Panel panelScatter;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label labelMFD;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cbFactory;
    private System.Windows.Forms.ComboBox cbLine;
    private System.Windows.Forms.ComboBox cbDevice;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.Panel panel1;
    
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Panel panel2;
    
    private CircularProgressBar_NET5.CircularProgressBar cpbTemp;
    private CircularProgressBar_NET5.CircularProgressBar cpbSpeed;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
    private System.Windows.Forms.Panel panel11;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
    private System.Windows.Forms.Panel panel9;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartVibration;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartMagFd;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartAccoustic;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.MonthCalendar monthCalendar1;
  }
}