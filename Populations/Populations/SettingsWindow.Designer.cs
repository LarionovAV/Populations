namespace Populations
{
    partial class SettingsWindow
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
            this.ManualRB = new System.Windows.Forms.RadioButton();
            this.AutoRefreshRB = new System.Windows.Forms.RadioButton();
            this.FixedItterRB = new System.Windows.Forms.RadioButton();
            this.ItterCountTextBox = new System.Windows.Forms.TextBox();
            this.RefreshModePanel = new System.Windows.Forms.GroupBox();
            this.MathModelPanel = new System.Windows.Forms.GroupBox();
            this.LogModelRB = new System.Windows.Forms.RadioButton();
            this.NPopModelRB = new System.Windows.Forms.RadioButton();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.RefreshModePanel.SuspendLayout();
            this.MathModelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManualRB
            // 
            this.ManualRB.AutoSize = true;
            this.ManualRB.Location = new System.Drawing.Point(6, 27);
            this.ManualRB.Name = "ManualRB";
            this.ManualRB.Size = new System.Drawing.Size(77, 21);
            this.ManualRB.TabIndex = 1;
            this.ManualRB.TabStop = true;
            this.ManualRB.Text = "Ручной";
            this.ManualRB.UseVisualStyleBackColor = true;
            // 
            // AutoRefreshRB
            // 
            this.AutoRefreshRB.AutoSize = true;
            this.AutoRefreshRB.Location = new System.Drawing.Point(6, 54);
            this.AutoRefreshRB.Name = "AutoRefreshRB";
            this.AutoRefreshRB.Size = new System.Drawing.Size(60, 21);
            this.AutoRefreshRB.TabIndex = 1;
            this.AutoRefreshRB.TabStop = true;
            this.AutoRefreshRB.Text = "Авто";
            this.AutoRefreshRB.UseVisualStyleBackColor = true;
            // 
            // FixedItterRB
            // 
            this.FixedItterRB.AutoSize = true;
            this.FixedItterRB.Location = new System.Drawing.Point(6, 81);
            this.FixedItterRB.Name = "FixedItterRB";
            this.FixedItterRB.Size = new System.Drawing.Size(166, 21);
            this.FixedItterRB.TabIndex = 1;
            this.FixedItterRB.TabStop = true;
            this.FixedItterRB.Text = "Несколько итераций";
            this.FixedItterRB.UseVisualStyleBackColor = true;
            this.FixedItterRB.CheckedChanged += new System.EventHandler(this.FixedItterRB_CheckedChanged);
            // 
            // ItterCountTextBox
            // 
            this.ItterCountTextBox.Location = new System.Drawing.Point(179, 81);
            this.ItterCountTextBox.Name = "ItterCountTextBox";
            this.ItterCountTextBox.Size = new System.Drawing.Size(47, 22);
            this.ItterCountTextBox.TabIndex = 2;
            // 
            // RefreshModePanel
            // 
            this.RefreshModePanel.Controls.Add(this.AutoRefreshRB);
            this.RefreshModePanel.Controls.Add(this.ItterCountTextBox);
            this.RefreshModePanel.Controls.Add(this.ManualRB);
            this.RefreshModePanel.Controls.Add(this.FixedItterRB);
            this.RefreshModePanel.Location = new System.Drawing.Point(31, 23);
            this.RefreshModePanel.Name = "RefreshModePanel";
            this.RefreshModePanel.Size = new System.Drawing.Size(240, 170);
            this.RefreshModePanel.TabIndex = 3;
            this.RefreshModePanel.TabStop = false;
            this.RefreshModePanel.Text = "Режим";
            // 
            // MathModelPanel
            // 
            this.MathModelPanel.Controls.Add(this.NPopModelRB);
            this.MathModelPanel.Controls.Add(this.LogModelRB);
            this.MathModelPanel.Location = new System.Drawing.Point(391, 23);
            this.MathModelPanel.Name = "MathModelPanel";
            this.MathModelPanel.Size = new System.Drawing.Size(267, 170);
            this.MathModelPanel.TabIndex = 4;
            this.MathModelPanel.TabStop = false;
            this.MathModelPanel.Text = "Математическая модель";
            // 
            // LogModelRB
            // 
            this.LogModelRB.AutoSize = true;
            this.LogModelRB.Location = new System.Drawing.Point(7, 37);
            this.LogModelRB.Name = "LogModelRB";
            this.LogModelRB.Size = new System.Drawing.Size(180, 21);
            this.LogModelRB.TabIndex = 0;
            this.LogModelRB.TabStop = true;
            this.LogModelRB.Text = "Логистическая модель";
            this.LogModelRB.UseVisualStyleBackColor = true;
            // 
            // NPopModelRB
            // 
            this.NPopModelRB.AutoSize = true;
            this.NPopModelRB.Location = new System.Drawing.Point(7, 64);
            this.NPopModelRB.Name = "NPopModelRB";
            this.NPopModelRB.Size = new System.Drawing.Size(247, 21);
            this.NPopModelRB.TabIndex = 0;
            this.NPopModelRB.TabStop = true;
            this.NPopModelRB.Text = "Модель взаимодействия N видов";
            this.NPopModelRB.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(505, 219);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(153, 48);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptBtn.Location = new System.Drawing.Point(344, 219);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(153, 48);
            this.AcceptBtn.TabIndex = 6;
            this.AcceptBtn.Text = "Принять";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 293);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.MathModelPanel);
            this.Controls.Add(this.RefreshModePanel);
            this.Name = "SettingsWindow";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.RefreshModePanel.ResumeLayout(false);
            this.RefreshModePanel.PerformLayout();
            this.MathModelPanel.ResumeLayout(false);
            this.MathModelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ItterCountTextBox;
        private System.Windows.Forms.RadioButton FixedItterRB;
        private System.Windows.Forms.RadioButton AutoRefreshRB;
        private System.Windows.Forms.RadioButton ManualRB;
        private System.Windows.Forms.GroupBox RefreshModePanel;
        private System.Windows.Forms.GroupBox MathModelPanel;
        private System.Windows.Forms.RadioButton NPopModelRB;
        private System.Windows.Forms.RadioButton LogModelRB;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AcceptBtn;
    }
}