namespace Populations
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.StopRefreshBtn = new System.Windows.Forms.Button();
            this.StartRefreshBtn = new System.Windows.Forms.Button();
            this.InitBtn = new System.Windows.Forms.Button();
            this.GraficChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HystoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CircleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HystoChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ControlPanel.Controls.Add(this.StopRefreshBtn);
            this.ControlPanel.Controls.Add(this.StartRefreshBtn);
            this.ControlPanel.Controls.Add(this.InitBtn);
            this.ControlPanel.Location = new System.Drawing.Point(700, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(240, 530);
            this.ControlPanel.TabIndex = 0;
            // 
            // StopRefreshBtn
            // 
            this.StopRefreshBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopRefreshBtn.Location = new System.Drawing.Point(54, 459);
            this.StopRefreshBtn.Name = "StopRefreshBtn";
            this.StopRefreshBtn.Size = new System.Drawing.Size(145, 43);
            this.StopRefreshBtn.TabIndex = 0;
            this.StopRefreshBtn.Text = "Остановить";
            this.StopRefreshBtn.UseVisualStyleBackColor = true;
            // 
            // StartRefreshBtn
            // 
            this.StartRefreshBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartRefreshBtn.Location = new System.Drawing.Point(54, 410);
            this.StartRefreshBtn.Name = "StartRefreshBtn";
            this.StartRefreshBtn.Size = new System.Drawing.Size(145, 43);
            this.StartRefreshBtn.TabIndex = 0;
            this.StartRefreshBtn.Text = "Выполнить";
            this.StartRefreshBtn.UseVisualStyleBackColor = true;
            // 
            // InitBtn
            // 
            this.InitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitBtn.Location = new System.Drawing.Point(54, 12);
            this.InitBtn.Name = "InitBtn";
            this.InitBtn.Size = new System.Drawing.Size(145, 43);
            this.InitBtn.TabIndex = 0;
            this.InitBtn.Text = "Инициализация";
            this.InitBtn.UseVisualStyleBackColor = true;
            this.InitBtn.Click += new System.EventHandler(this.InitBtn_Click);
            // 
            // GraficChart
            // 
            this.GraficChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.GraficChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.GraficChart.Legends.Add(legend4);
            this.GraficChart.Location = new System.Drawing.Point(0, 0);
            this.GraficChart.Name = "GraficChart";
            this.GraficChart.Size = new System.Drawing.Size(700, 265);
            this.GraficChart.TabIndex = 1;
            this.GraficChart.Text = "График";
            // 
            // HystoChart
            // 
            this.HystoChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.HystoChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.HystoChart.Legends.Add(legend5);
            this.HystoChart.Location = new System.Drawing.Point(-6, 265);
            this.HystoChart.Name = "HystoChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.HystoChart.Series.Add(series3);
            this.HystoChart.Size = new System.Drawing.Size(350, 265);
            this.HystoChart.TabIndex = 2;
            this.HystoChart.Text = "Гистограма";
            // 
            // CircleChart
            // 
            this.CircleChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.CircleChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.CircleChart.Legends.Add(legend6);
            this.CircleChart.Location = new System.Drawing.Point(350, 265);
            this.CircleChart.Name = "CircleChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.CircleChart.Series.Add(series4);
            this.CircleChart.Size = new System.Drawing.Size(350, 265);
            this.CircleChart.TabIndex = 3;
            this.CircleChart.Text = "Круговая диаграмма";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 530);
            this.Controls.Add(this.CircleChart);
            this.Controls.Add(this.HystoChart);
            this.Controls.Add(this.GraficChart);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Динамика популяций";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraficChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HystoChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button StopRefreshBtn;
        private System.Windows.Forms.Button StartRefreshBtn;
        private System.Windows.Forms.Button InitBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart HystoChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart CircleChart;
    }
}

