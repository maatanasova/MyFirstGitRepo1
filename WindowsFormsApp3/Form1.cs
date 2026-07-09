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
        private List<ICurrency> listOfCurrencies = new List<ICurrency>() { 
            new EUROCurrency(),
            new USDCurrency(),
            new PoundCurrency()
        };
        public Form1()
        {
            InitializeComponent();
            FillComboBoxesWithData();
        }

        private void FillComboBoxesWithData()
        {
            foreach(ICurrency currency in listOfCurrencies)
            {
                cmbMainCurrency.Items.Add(currency.CurrencyName);
                cmbTargetCurrency.Items.Add(currency.CurrencyName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private bool ValidateInputData(
            int selectedMainCurrencyIdx, 
            int selectedTargetedCurrencyIdx,
            double amount
            )
        {
            if (selectedMainCurrencyIdx < 0)
            {
                MessageBox.Show("Моля изберете основна валута!");
                return false;
            }
            if (selectedTargetedCurrencyIdx < 0)
            {
                MessageBox.Show("Моля изберете целева валута!");
                return false;
            }
            if (amount <= 0)
            {
                MessageBox.Show("Моля въведете сума!");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedMainCurrencyIdx = cmbMainCurrency.SelectedIndex;
            int selectedTargetedCurrencyIdx = cmbTargetCurrency.SelectedIndex;

            double amount = 0.0;
            Double.TryParse(txtCommand.Text, out amount);

            bool inputDataIsValid = ValidateInputData(
                selectedMainCurrencyIdx,
                selectedTargetedCurrencyIdx,
                amount
                );

            if(inputDataIsValid)
            {
                ICurrency mainCurrency = listOfCurrencies[selectedMainCurrencyIdx];
                ICurrency targetCurrency = listOfCurrencies[selectedTargetedCurrencyIdx];

                double result = amount * targetCurrency.CurrencyRate;

                lblResult.Text = String.Format("За {0} {1} получавате {2} {3}", amount, mainCurrency.CurrencyName, result, targetCurrency.CurrencyName);
            }
        }
    }
}
