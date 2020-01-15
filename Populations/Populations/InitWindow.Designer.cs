namespace Populations
{
    partial class InitWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InitTable = new System.Windows.Forms.DataGridView();
            this.SpecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InitTable)).BeginInit();
            this.SuspendLayout();
            // 
            // InitTable
            // 
            this.InitTable.AllowUserToAddRows = false;
            this.InitTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InitTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecName,
            this.Count,
            this.MaxCount,
            this.Birth,
            this.Death});
            this.InitTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.InitTable.Location = new System.Drawing.Point(0, 0);
            this.InitTable.MultiSelect = false;
            this.InitTable.Name = "InitTable";
            this.InitTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InitTable.Size = new System.Drawing.Size(716, 150);
            this.InitTable.TabIndex = 0;
            this.InitTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.InitTable_UserDeletingRow);
            // 
            // SpecName
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            this.SpecName.DefaultCellStyle = dataGridViewCellStyle6;
            this.SpecName.Frozen = true;
            this.SpecName.HeaderText = "Название вида";
            this.SpecName.Name = "SpecName";
            this.SpecName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Count
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N0";
            this.Count.DefaultCellStyle = dataGridViewCellStyle7;
            this.Count.Frozen = true;
            this.Count.HeaderText = "Численность";
            this.Count.Name = "Count";
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaxCount
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N0";
            this.MaxCount.DefaultCellStyle = dataGridViewCellStyle8;
            this.MaxCount.Frozen = true;
            this.MaxCount.HeaderText = "Максимальная численность";
            this.MaxCount.Name = "MaxCount";
            this.MaxCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Birth
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "N0";
            this.Birth.DefaultCellStyle = dataGridViewCellStyle9;
            this.Birth.Frozen = true;
            this.Birth.HeaderText = "Рождаемость";
            this.Birth.Name = "Birth";
            this.Birth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Death
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N0";
            this.Death.DefaultCellStyle = dataGridViewCellStyle10;
            this.Death.Frozen = true;
            this.Death.HeaderText = "Смертность";
            this.Death.Name = "Death";
            this.Death.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Death.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptBtn.Location = new System.Drawing.Point(468, 189);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(115, 39);
            this.AcceptBtn.TabIndex = 1;
            this.AcceptBtn.Text = "Принять";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(589, 189);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(115, 39);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRowBtn.Location = new System.Drawing.Point(12, 189);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(151, 39);
            this.AddRowBtn.TabIndex = 1;
            this.AddRowBtn.Text = "Добавить запись";
            this.AddRowBtn.UseVisualStyleBackColor = true;
            this.AddRowBtn.Click += new System.EventHandler(this.AddRowBtn_Click);
            // 
            // InitWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 240);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddRowBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.InitTable);
            this.Name = "InitWindow";
            this.Text = "Инициализация видов";
            this.Load += new System.EventHandler(this.InitWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InitTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InitTable;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Death;
    }
}