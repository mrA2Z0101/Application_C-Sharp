using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Dates
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int month = int.Parse(txtMonth.Text);
                int day = int.Parse(txtDay.Text);
                int year = int.Parse(txtYear.Text);

                if (month * day == year)
                {
                    lblResult.Text = "The date is Magic!";
                }
                else
                {
                    lblResult.Text = "The date is not Magic!";
                }
            }
            catch (FormatException)
            {
                lblResult.Text = "Please enter valid numeric values";
            }
        }
    }
}