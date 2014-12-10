using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bank = bankName.Text;
            double time = Convert.ToDouble(timeInYear.Text);
            double prAmount = Convert.ToDouble(principleAmount.Text);
            double intRate = Convert.ToDouble(interestRate.Text);
            if (bank == "BRAC")
            {
                double tbbrac = prAmount*time*intRate;
                double tbbrac3 = tbbrac/100;
                interestResult.Text = tbbrac3.ToString();
            }
            else if (bank == "DBBL")
            {
                double tbdbbl = prAmount * time * intRate;
                double tbdbbl3 = tbdbbl / 100;
                interestResult.Text = tbdbbl3.ToString();
            }
            else if (bank == "HSBC")
            {
                double tbhsbc = prAmount * time * intRate;
                double tbhsbc3 = tbhsbc / 100;
                interestResult.Text = tbhsbc3.ToString();
            }
            else
            {
                double tbucb = prAmount * time * intRate;
                double tbucb3 = tbucb / 100;
                interestResult.Text = tbucb3.ToString();
            }
        }
    }
}
