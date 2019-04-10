using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineSim
{
    public partial class VendingMachine : Form
    {
        public VendingMachine()
        {
            InitializeComponent();
        }
        public struct sodaInput
        {
            public string name;
            public string sodaPrice;
            public double sodaQuantity;
        }
        string[,] soda = new string[,] { {"Cola", "1.00", "20"}, {"Root Beer", "1.00", "20" },
                                        {"Grape Soda", "1.50", "20"}, {"Lemon Lime", "1.00", "20"}, {"Cream Soda", "1.50", "20"} };
        double totalSales = 0.00;
        int index;
        sodaInput input = new sodaInput();

        private void soldOut()
        {
            input.name = soda[index, 0];
            input.sodaPrice = soda[index, 1];
            input.sodaQuantity = int.Parse(soda[index,2]);

            if(input.sodaQuantity == 0)
            {
                MessageBox.Show(input.name + " is sold out");
            }
            else
            {
                input.sodaQuantity--;
                soda[index, 2] = input.sodaQuantity.ToString();
                switch (index)
                {
                    case 0: colaLabel.Text = input.sodaQuantity.ToString();
                        break;
                    case 1: rootBeerLabel.Text = input.sodaQuantity.ToString();
                        break;
                    case 2: grapeLabel.Text = input.sodaQuantity.ToString();
                        break;
                    case 3: lemonLimeLabel.Text = input.sodaQuantity.ToString();
                        break;
                    case 4: creamLabel.Text = input.sodaQuantity.ToString();
                        break;
                }

                totalSales += double.Parse(input.sodaPrice);

                totalSalesLabel.Text = "$" + totalSales.ToString();
            }
        }

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            index = 0;
            soldOut();
        }

        private void rootBeerPictureBox_Click(object sender, EventArgs e)
        {
            index = 1;
            soldOut();
        }

        private void grapeSodaPictureBox_Click(object sender, EventArgs e)
        {
            index = 2;
            soldOut();
        }

        private void lemonLimePictureBox_Click(object sender, EventArgs e)
        {
            index = 3;
            soldOut();
        }

        private void creamSodaPictureBox_Click(object sender, EventArgs e)
        {
            index = 4;
            soldOut();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
