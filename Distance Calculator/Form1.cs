using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Clears the Results box on every calculation
            listBoxResults.Items.Clear();

            if (int.TryParse(txtSpeed.Text, out int speed) && int.TryParse(txtHours.Text, out int hours))
            {
                for (int i = 1; i <= hours; i++)
                {
                    //If speed is over 50mph it calculates the speed and says Woah that's fast in the beginning
                    if(speed >= 50)
                    {
                        int distance = speed * i;
                        listBoxResults.Items.Add($"Woah that's FAST! After hour {i} the distance is {distance}!");
                    }
                    //If speed is under 50mph it calculates the speed and says Hurry up slowpoke in the beginning
                    else
                    {
                        int distance = speed * i;
                        listBoxResults.Items.Add($"HURRY UP SLOWPOKE! After hour {i} the distance is {distance}!");
                    }
                }
            }
            else
            {
                //Displays an error message when a number is not displayed in the speed textbox
                MessageBox.Show("Error 404: Please enter valid numbers for speed and hour!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
