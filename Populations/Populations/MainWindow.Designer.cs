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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.MessageField = new System.Windows.Forms.TextBox();
            this.StopRefreshBtn = new System.Windows.Forms.Button();
            this.RestoreBtm = new System.Windows.Forms.Button();
            this.TakeSnapshotBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
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
            this.ControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ControlPanel.Controls.Add(this.MessageField);
            this.ControlPanel.Controls.Add(this.StopRefreshBtn);
            this.ControlPanel.Controls.Add(this.RestoreBtm);
            this.ControlPanel.Controls.Add(this.TakeSnapshotBtn);
            this.ControlPanel.Controls.Add(this.SettingsBtn);
            this.ControlPanel.Controls.Add(this.StartRefreshBtn);
            this.ControlPanel.Controls.Add(this.InitBtn);
            this.ControlPanel.Location = new System.Drawing.Point(700, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(240, 530);
            this.ControlPanel.TabIndex = 0;
            // 
            // MessageField
            // 
            this.MessageField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageField.Enabled = false;
            this.MessageField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageField.ForeColor = System.Drawing.Color.DarkGreen;
            this.MessageField.Location = new System.Drawing.Point(0, 403);
            this.MessageField.Margin = new System.Windows.Forms.Padding(2);
            this.MessageField.Multiline = true;
            this.MessageField.Name = "MessageField";
            this.MessageField.ReadOnly = true;
            this.MessageField.Size = new System.Drawing.Size(240, 127);
            this.MessageField.TabIndex = 1;
            // 
            // StopRefreshBtn
            // 
            this.StopRefreshBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopRefreshBtn.Location = new System.Drawing.Point(54, 110);
            this.StopRefreshBtn.Name = "StopRefreshBtn";
            this.StopRefreshBtn.Size = new System.Drawing.Size(145, 43);
            this.StopRefreshBtn.TabIndex = 0;
            this.StopRefreshBtn.Text = "Остановить";
            this.StopRefreshBtn.UseVisualStyleBackColor = true;
            this.StopRefreshBtn.Click += new System.EventHandler(this.StopRefreshBtn_Click);
            // 
            // RestoreBtm
            // 
            this.RestoreBtm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestoreBtm.Location = new System.Drawing.Point(54, 259);
            this.RestoreBtm.Name = "RestoreBtm";
            this.RestoreBtm.Size = new System.Drawing.Size(145, 43);
            this.RestoreBtm.TabIndex = 0;
            this.RestoreBtm.Text = "Восстановить";
            this.RestoreBtm.UseVisualStyleBackColor = true;
            this.RestoreBtm.Click += new System.EventHandler(this.RestoreBtm_Click);
            // 
            // TakeSnapshotBtn
            // 
            this.TakeSnapshotBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeSnapshotBtn.Location = new System.Drawing.Point(17, 210);
            this.TakeSnapshotBtn.Name = "TakeSnapshotBtn";
            this.TakeSnapshotBtn.Size = new System.Drawing.Size(213, 43);
            this.TakeSnapshotBtn.TabIndex = 0;
            this.TakeSnapshotBtn.Text = "Сделать быстрый снимок";
            this.TakeSnapshotBtn.UseVisualStyleBackColor = true;
            this.TakeSnapshotBtn.Click += new System.EventHandler(this.TakeSnapshotBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsBtn.Location = new System.Drawing.Point(54, 160);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(145, 43);
            this.SettingsBtn.TabIndex = 0;
            this.SettingsBtn.Text = "Настройки";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // StartRefreshBtn
            // 
            this.StartRefreshBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartRefreshBtn.Location = new System.Drawing.Point(54, 62);
            this.StartRefreshBtn.Name = "StartRefreshBtn";
            this.StartRefreshBtn.Size = new System.Drawing.Size(145, 43);
            this.StartRefreshBtn.TabIndex = 0;
            this.StartRefreshBtn.Text = "Выполнить";
            this.StartRefreshBtn.UseVisualStyleBackColor = true;
            this.StartRefreshBtn.Click += new System.EventHandler(this.StartRefreshBtn_Click);
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
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.GraficChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficChart.Legends.Add(legend1);
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
            chartArea2.Name = "ChartArea1";
            this.HystoChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.HystoChart.Legends.Add(legend2);
            this.HystoChart.Location = new System.Drawing.Point(-6, 265);
            this.HystoChart.Name = "HystoChart";
            this.HystoChart.Size = new System.Drawing.Size(350, 265);
            this.HystoChart.TabIndex = 2;
            this.HystoChart.Text = "Гистограма";
            // 
            // CircleChart
            // 
            this.CircleChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.CircleChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.CircleChart.Legends.Add(legend3);
            this.CircleChart.Location = new System.Drawing.Point(350, 265);
            this.CircleChart.Name = "CircleChart";
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
            this.ControlPanel.PerformLayout();
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
        private System.Windows.Forms.Button RestoreBtm;
        private System.Windows.Forms.Button TakeSnapshotBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.TextBox MessageField;
    }
}

