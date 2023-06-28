namespace Chayka_Pr_22_107k_Olimpiada
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbTypePay = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cbPercent = new System.Windows.Forms.ComboBox();
            this.cbSrok = new System.Windows.Forms.ComboBox();
            this.cbSum = new System.Windows.Forms.ComboBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.tbSrok = new System.Windows.Forms.TextBox();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры кредита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Настройки калькулятора позволяют задавать дополнительные параметры \r\nкредита, но " +
    "нужно учитывать, что в каждом банке есть свои особенности \r\nрасчетов.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма кредита:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Срок кредита:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Процентная ставка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Единовременные комиссии";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Вид платежа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Начало выплат";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(291, 368);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 46);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Расчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.cbMonth.Location = new System.Drawing.Point(232, 308);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(123, 24);
            this.cbMonth.TabIndex = 9;
            this.cbMonth.Text = "Мес.";
            // 
            // cbYear
            // 
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015"});
            this.cbYear.Location = new System.Drawing.Point(451, 308);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(69, 24);
            this.cbYear.TabIndex = 10;
            this.cbYear.Text = "Год";
            // 
            // cbTypePay
            // 
            this.cbTypePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTypePay.FormattingEnabled = true;
            this.cbTypePay.Items.AddRange(new object[] {
            "Аннуитетный",
            "Фиксированный"});
            this.cbTypePay.Location = new System.Drawing.Point(232, 275);
            this.cbTypePay.Name = "cbTypePay";
            this.cbTypePay.Size = new System.Drawing.Size(288, 24);
            this.cbTypePay.TabIndex = 11;
            this.cbTypePay.Text = "Аннуитетный";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Фиксированный",
            "% от суммы кредита."});
            this.comboBox4.Location = new System.Drawing.Point(526, 242);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(134, 24);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.Text = "Фиксированный";
            // 
            // cbPercent
            // 
            this.cbPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPercent.FormattingEnabled = true;
            this.cbPercent.Items.AddRange(new object[] {
            "% в год."});
            this.cbPercent.Location = new System.Drawing.Point(526, 185);
            this.cbPercent.Name = "cbPercent";
            this.cbPercent.Size = new System.Drawing.Size(134, 24);
            this.cbPercent.TabIndex = 13;
            this.cbPercent.Text = "% в год.";
            // 
            // cbSrok
            // 
            this.cbSrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSrok.FormattingEnabled = true;
            this.cbSrok.Items.AddRange(new object[] {
            "Мес.",
            "Год"});
            this.cbSrok.Location = new System.Drawing.Point(526, 148);
            this.cbSrok.Name = "cbSrok";
            this.cbSrok.Size = new System.Drawing.Size(84, 24);
            this.cbSrok.TabIndex = 14;
            this.cbSrok.Text = "Мес.";
            // 
            // cbSum
            // 
            this.cbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSum.FormattingEnabled = true;
            this.cbSum.Items.AddRange(new object[] {
            "Рубли",
            "Доллары"});
            this.cbSum.Location = new System.Drawing.Point(526, 108);
            this.cbSum.Name = "cbSum";
            this.cbSum.Size = new System.Drawing.Size(84, 24);
            this.cbSum.TabIndex = 15;
            this.cbSum.Text = "Рубли";
            // 
            // tbSum
            // 
            this.tbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSum.Location = new System.Drawing.Point(232, 108);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(288, 22);
            this.tbSum.TabIndex = 16;
            // 
            // tbSrok
            // 
            this.tbSrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSrok.Location = new System.Drawing.Point(232, 148);
            this.tbSrok.Name = "tbSrok";
            this.tbSrok.Size = new System.Drawing.Size(288, 22);
            this.tbSrok.TabIndex = 17;
            // 
            // tbPercent
            // 
            this.tbPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPercent.Location = new System.Drawing.Point(232, 185);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(288, 22);
            this.tbPercent.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(232, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(288, 22);
            this.textBox4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.tbSrok);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.cbSum);
            this.Controls.Add(this.cbSrok);
            this.Controls.Add(this.cbPercent);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.cbTypePay);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредитный кальулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbTypePay;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox cbPercent;
        private System.Windows.Forms.ComboBox cbSrok;
        private System.Windows.Forms.ComboBox cbSum;
        private System.Windows.Forms.TextBox tbSrok;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox tbSum;
    }
}

