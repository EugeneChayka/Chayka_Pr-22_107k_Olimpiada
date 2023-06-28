using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chayka_Pr_22_107k_Olimpiada
{
    public partial class Form1 : Form
    {
        double payment;
        double percentpayment;
        public Form1()
        {
            InitializeComponent();
        }
        public static double Schet()
        {
            return 0;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string date = cbYear.SelectedItem.ToString()+"-"+cbMonth.SelectedItem.ToString();
            DateTime data = DateTime.Parse(date);

            double sum = double.Parse(tbSum.Text.Replace(',', '.'));
            int month = int.Parse(tbSrok.Text);
            if (cbSrok.SelectedItem.ToString() == "Год")
              month = month * 12;
            double percent = 10 / (double.Parse(tbPercent.Text) * 100);
            double sums = sum;
            if (cbTypePay.SelectedItem.ToString() == "Аннуитетный")
            {
                payment = (percent * Math.Pow((1 + percent), month)) / (Math.Pow(1 + percent, month) - 1) * sum;
                double k = payment;
                double mainPayment = payment - percentpayment;
                for (int i = 0; i <= month; i++)
                {
                    if (i == 0)
                    {
                        percentpayment = sum * percent;
                        sums = percentpayment + mainPayment;


                    }
                    else if (i > 0)
                    {
                        mainPayment = k - percentpayment;
                        percentpayment = (sums - payment) * percent;
                        payment = (percent * Math.Pow((1 + percent), month - i)) / (Math.Pow(1 + percent, month - i) - 1) * sum;
                        sums = percentpayment+mainPayment;

                    }
                    
                }
                
               
            }
            else if (cbTypePay.SelectedItem.ToString() == "Фиксированный")
            {

            }
            //По времени не успел доделать расчеты, для проверки работоспособности сохранения сделал так
            Form form3 = new Result(data.ToString("yyyy/MM"), sums.ToString("0.00"), sum.ToString("0.00"), (sum/100* double.Parse(tbPercent.Text)).ToString("0.00"), (sum-sums).ToString("0.00"));
            form3.Show();
            this.Hide();

        }
    }
}
