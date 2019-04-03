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

namespace NameSearch
{
    public partial class NameSearch : Form
    {
        //Variable declaration
        const int SIZE = 200;
        string[] boyNamesArray = new string[SIZE];
        string[] girlNamesArray = new string[SIZE];
        bool popularBoy = false;
        bool popularGirl = false;

        public NameSearch()
        {
            InitializeComponent();

            //Declare file name variables.
            StreamReader boysNamesFile;
            StreamReader girlsNamesFile;

            int boyCount = 0;
            //open the file and populate arrays
            boysNamesFile = File.OpenText("BoyNames.txt");
            while (!boysNamesFile.EndOfStream && boyCount < boyNamesArray.Length)
            {
                boyNamesArray[boyCount] = boysNamesFile.ReadLine();
                boyCount++;
                Console.WriteLine(boyCount.ToString());
            }

            boysNamesFile.Close();

            int girlsCount = 0;
            //open the file and populate arrays
            girlsNamesFile = File.OpenText("GirlNames.txt");
            while (!girlsNamesFile.EndOfStream && girlsCount < girlNamesArray.Length)
            {
                girlNamesArray[girlsCount] = girlsNamesFile.ReadLine();
                girlsCount++;
                Console.WriteLine(girlsCount.ToString());
            }
        }

        //Exit Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clear Button
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
        }

        //Get method for popular boy name
        private bool getBoyValue(string textBoxName)
        {
            for (int i = 0; i < boyNamesArray.Length; i++)
            {
                if (nameTextBox.Text.Contains(boyNamesArray[i]) == true)
                {
                    popularBoy = textBoxName.Contains(boyNamesArray[i]);
                }
            }
            return popularBoy;
        }

        //Get method for popular girls name
        private bool getGirlValue(string textBoxName)
        {
            for (int i = 0; i < girlNamesArray.Length; i++)
            {
                if(nameTextBox.Text.Contains(girlNamesArray[i]) == true)
                {
                    popularGirl = textBoxName.Contains(girlNamesArray[i]);
                } 
            }
            return popularGirl;
        }

        //Search button
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name to continue");
                return;
            }

            if (getBoyValue(nameTextBox.Text) == true && getGirlValue(nameTextBox.Text) == true)
            {
                MessageBox.Show(nameTextBox.Text + " are popular names.");
                popularBoy = false;
                popularGirl = false;
                return;
            }

            if (getBoyValue(nameTextBox.Text) == true)
            {
                MessageBox.Show(nameTextBox.Text + " is a popular boys name.");
                popularBoy = false;
                return;
            }
            if (getGirlValue(nameTextBox.Text) == true)
            {
                MessageBox.Show(nameTextBox.Text + " is a popular girls name");
                popularGirl = false;
                return;
            }
            else
            {
                MessageBox.Show(nameTextBox.Text + " is not a popular name.");
                return;
            }
        }
    }
}
  