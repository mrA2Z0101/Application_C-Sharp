using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distanced_Traveled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculateDistance5Hours_Click(object sender, EventArgs e)
        {
            CalculateDistance(5);
        }

        private void calculateDistance8Hours_Click(object sender, EventArgs e)
        {
            CalculateDistance(8);
        }

        private void calculateDistance12Hours_Click(object sender, EventArgs e)
        {
            CalculateDistance(12);
        }

        private void CalculateDistance(int hours)
        {
            try
            {
                double speed = double.Parse(insertSpeed.Text);
                double distance = speed * hours;
                distanceHere.Text = $"Your car will travel {distance} miles in {hours} hours.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a Valid Speed!");
            }
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
