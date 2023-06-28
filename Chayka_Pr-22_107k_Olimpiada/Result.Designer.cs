namespace Chayka_Pr_22_107k_Olimpiada
{
    partial class Result
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBasicArrears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSumPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArrears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumPay = new System.Windows.Forms.Label();
            this.lblPercentPay = new System.Windows.Forms.Label();
            this.lblCommisPay = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnDate,
            this.ColumnSum,
            this.ColumnBasicArrears,
            this.ColumnSumPercent,
            this.ColumnArrears});
            this.dataGridView1.Location = new System.Drawing.Point(-40, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnNumber.HeaderText = "№";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.Width = 43;
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDate.HeaderText = "Дата платежа";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnSum
            // 
            this.ColumnSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSum.HeaderText = "Сумма платежа";
            this.ColumnSum.Name = "ColumnSum";
            // 
            // ColumnBasicArrears
            // 
            this.ColumnBasicArrears.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBasicArrears.HeaderText = "Сумма погашения основного долга";
            this.ColumnBasicArrears.Name = "ColumnBasicArrears";
            // 
            // ColumnSumPercent
            // 
            this.ColumnSumPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSumPercent.HeaderText = "Сумма начисленных процентов";
            this.ColumnSumPercent.Name = "ColumnSumPercent";
            // 
            // ColumnArrears
            // 
            this.ColumnArrears.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnArrears.HeaderText = "Остаток задолженности";
            this.ColumnArrears.Name = "ColumnArrears";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая сумма платежей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Переплата по процентам за кредит:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Итоговая переплата с учетом комиссий:";
            // 
            // lblSumPay
            // 
            this.lblSumPay.AutoSize = true;
            this.lblSumPay.Location = new System.Drawing.Point(259, 381);
            this.lblSumPay.Name = "lblSumPay";
            this.lblSumPay.Size = new System.Drawing.Size(35, 13);
            this.lblSumPay.TabIndex = 4;
            this.lblSumPay.Text = "label4";
            // 
            // lblPercentPay
            // 
            this.lblPercentPay.AutoSize = true;
            this.lblPercentPay.Location = new System.Drawing.Point(259, 405);
            this.lblPercentPay.Name = "lblPercentPay";
            this.lblPercentPay.Size = new System.Drawing.Size(35, 13);
            this.lblPercentPay.TabIndex = 5;
            this.lblPercentPay.Text = "label5";
            // 
            // lblCommisPay
            // 
            this.lblCommisPay.AutoSize = true;
            this.lblCommisPay.Location = new System.Drawing.Point(259, 428);
            this.lblCommisPay.Name = "lblCommisPay";
            this.lblCommisPay.Size = new System.Drawing.Size(35, 13);
            this.lblCommisPay.TabIndex = 6;
            this.lblCommisPay.Text = "label6";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(677, 402);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(111, 36);
            this.btnFile.TabIndex = 7;
            this.btnFile.Text = "Выгрузить в файл";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblCommisPay);
            this.Controls.Add(this.lblPercentPay);
            this.Controls.Add(this.lblSumPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Result";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumPay;
        private System.Windows.Forms.Label lblPercentPay;
        private System.Windows.Forms.Label lblCommisPay;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBasicArrears;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArrears;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}