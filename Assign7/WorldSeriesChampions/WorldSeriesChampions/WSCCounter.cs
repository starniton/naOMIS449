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

namespace WorldSeriesChampions
{
    public partial class WSCForm : Form
    {

        const int SIZE = 29;
        string[] teamsArray = new string[SIZE];
        string[] winnersArray = new string[SIZE];

        public WSCForm()
        {
            InitializeComponent();

            //Declare a StreamReader variable.
            StreamReader teamsFile;
            StreamReader winnersFile;

            int count = 0;
            //open the file and get a StreamReader Object
            teamsFile = File.OpenText("Teams.txt");
            while (!teamsFile.EndOfStream && count < teamsArray.Length)
            {
                teamsArray[count] = teamsFile.ReadLine();
                count++;
                Console.WriteLine(count.ToString());
            }

            //Close file
            teamsFile.Close();

            //Declare a StreamReader variable.

            int textCount = 0;
            //open the file and get a StreamReader Object
            winnersFile = File.OpenText("WorldSeriesWinners.txt");
            while (!winnersFile.EndOfStream && textCount < winnersArray.Length)
            {
                winnersArray[textCount] = winnersFile.ReadLine();
                textCount++;
                Console.WriteLine(textCount.ToString());
            }

            winnersFile.Close();

            for (int i = 0; i < teamsArray.Length; i++)
            {
                teamsListBox.Items.Add(teamsArray[i]);
                //Console.WriteLine(i.ToString());
                //Console.WriteLine(teamsArray[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            winsTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teamName = teamsListBox.SelectedItem.ToString();
            int winCount = 0;
            for (int i = 0; i < winnersArray.Length; i++)
            {
                if (teamName == winnersArray[i])
                {
                    winCount++;
                }
                winsTextBox.Text = winCount + " games won from 1903 to 2012.";
            }
        }

        private void teamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamLabel.Text = teamsListBox.SelectedItem.ToString();
        }
    }
}
