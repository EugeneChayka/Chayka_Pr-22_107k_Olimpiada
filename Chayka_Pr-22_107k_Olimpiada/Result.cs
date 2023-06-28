using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chayka_Pr_22_107k_Olimpiada
{
    public partial class Result : Form
    {
        int sum;
        public Result(string date, string dolg, string Sum, string percentpayment, string ostatok)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(1,date, dolg,Sum, percentpayment, ostatok);
            
            
            
            lblSumPay.Text = Sum;
            lblPercentPay.Text = percentpayment;
            lblCommisPay.Text = percentpayment;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save=new SaveFileDialog();
            Save.Filter = "CSV files (*.csv) |*.csv|Все файлы (*.*)|*.*";
            Save.Title ="Сохранить график платежей";
            Save.ShowDialog();
            string strok = "Номер,Дата,Сумма,Долг,Проценты,Остаток";
            StringBuilder sb = new StringBuilder();
            sb.Append(strok);
            sb.AppendLine();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {   if(i < dataGridView1.Columns.Count-1&& row.Cells[i].Value !=null)
                    sb.Append(row.Cells[i].Value + ",");
                    else 
                    sb.Append(row.Cells[i].Value);
                }
                sb.AppendLine();
            }
            File.WriteAllText (Save.FileName, sb.ToString());
        }
    }
}
