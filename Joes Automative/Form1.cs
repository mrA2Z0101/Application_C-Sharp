using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joes_Automative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal OilChangeCharges()
        {
            if (chkOilChange.Checked)
            {
                return 50m;
            }
            return 0m;
        }
        
        private decimal LubeCharges()
        {
            if (chkLubeJob.Checked)
            {
                return 40m;
            }
            return 0m;
        }
        
        private decimal RadiatorFlushCharges()
        {
            if (chkRadiatorFlush.Checked)
            {
                return 100m;
            }
            return 0m;
        }

        private decimal TransmissionFlushCharges()
        {
            if (chkTransmissionFlush.Checked)
            {
                return 120m;
            }
            return 0m;
        }

        private decimal InspectionCharges()
        {
            if (chkInspection.Checked)
            {
                return 35m;
            }
            return 0m;
        }

        private decimal MufflerCharges()
        {
            if (chkMufflerReplacement.Checked)
            {
                return 150m;
            }
            return 0m;
        }

        private decimal TireRotationCharges()
        {
            if (chkTireRotation.Checked)
            {
                return 25m;
            }
            return 0m;
        }

        private decimal PartsCharges()
        {
            if (decimal.TryParse(txtParts.Text, out decimal partsCost))
            {
                return partsCost;
            }
            return 0m;
        }

        private decimal LaborCharges()
        {
            if (decimal.TryParse(txtLabor.Text, out decimal laborHours))
            {
                return laborHours * 75m;
            }
            return 0m;
        }

        private decimal TaxCharges()
        {
            return PartsCharges() * 0.08m;
        }

        private decimal TotalCharges()
        {
            decimal total = OilChangeCharges() + LubeCharges() + RadiatorFlushCharges() + TransmissionFlushCharges() + InspectionCharges() + MufflerCharges() + TireRotationCharges() + PartsCharges() + LaborCharges() + TaxCharges();
            return total;
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal servicesTotal = OilChangeCharges() + LubeCharges() + RadiatorFlushCharges() + TransmissionFlushCharges() + InspectionCharges() + MufflerCharges() + TireRotationCharges();

            decimal partsTotal = PartsCharges();
            decimal laborTotal = LaborCharges();
            decimal taxTotal = TaxCharges();
            decimal total = TotalCharges();

            lblServiceTotal.Text = servicesTotal.ToString("c");
            lblPartsTotal.Text = partsTotal.ToString("c");
            lblLaborTotal.Text = laborTotal.ToString("c");
            lblTaxTotal.Text = taxTotal.ToString("c");
            lblTotal.Text = total.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkInspection.Checked = false;
            chkLubeJob.Checked = false;
            chkMufflerReplacement.Checked = false;
            chkOilChange.Checked = false;
            chkRadiatorFlush.Checked = false;
            chkTireRotation.Checked = false;
            chkTransmissionFlush.Checked = false;

            txtLabor.Clear();
            txtParts.Clear();

            lblLaborTotal.Text = "";
            lblPartsTotal.Text = "";
            lblServiceTotal.Text = "";
            lblTaxTotal.Text = "";
            lblTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
