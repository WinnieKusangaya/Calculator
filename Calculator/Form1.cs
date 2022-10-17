using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentCalculation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            tbResult.Text = currentCalculation;
        }

        private void BtEquals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString();

            try
            {
                tbResult.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = tbResult.Text;

                if (formattedCalculation.Contains("/0") == true)
                {
                    tbResult.Text = "Error";
                    currentCalculation = "";
                }
            }
            catch (Exception ex)
            {
                tbResult.Text = "Error";
                currentCalculation = "";
            }

           
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            currentCalculation = "";
        }

        private void BTClearEntry_Click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }

            tbResult.Text = currentCalculation;
        }
    }
}
