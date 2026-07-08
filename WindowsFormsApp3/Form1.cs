using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double usd;
            double sum = 0;
            double exchangeRate = 0.85;

            if (double.TryParse(textBox1.Text, out usd))
            {
                sum = usd * exchangeRate;
                label2.Text = "EUR: " + sum.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
