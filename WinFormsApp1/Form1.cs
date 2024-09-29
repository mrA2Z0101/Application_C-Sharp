using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button for Autem. Translates the Latin word Autem to the English word UP.
        private void translateAutem_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "UP!";
        }

        //Button for Descendit. Translates the Latin word Descendit to the English word DOWN.
        private void translateDescendit_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "DOWN!";
        }

        //Button for Medium. Translates the Latin word Medium to the English word CENTER.
        private void TranslateMedium_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "CENTER!";
        }
    }
}
