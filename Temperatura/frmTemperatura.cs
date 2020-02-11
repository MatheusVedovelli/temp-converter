using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class frmTemperatura : Form
    {
        public double CtoK(double value)
        {
            return value + 273.15f;
        }

        public double CtoF(double value)
        {
            return (value * 9 / 5) + 32;
        }

        public double KtoC(double value)
        {
            return value - 273.15f;
        }

        public double KtoF(double value)
        {
            return CtoF(KtoC(value));
        }

        public double FtoC(double value)
        {
            return (value - 32) * 5 / 9;
        }

        public double FtoK(double value)
        {
            return CtoK(FtoC(value));
        }
        public string Convert(double value)
        {
            if(rdbC1.Checked)
            {
                if (rdbC2.Checked)
                    return Math.Round(value, 2).ToString();
                else if (rdbK2.Checked)
                    return Math.Round(CtoK(value), 2).ToString();
                else if (rdbF2.Checked)
                    return Math.Round(CtoF(value), 2).ToString();
            }
            else if(rdbK1.Checked)
            {
                if (rdbC2.Checked)
                    return Math.Round(KtoC(value), 2).ToString();
                else if (rdbK2.Checked)
                    return Math.Round(value, 2).ToString();
                else if (rdbF2.Checked)
                    return Math.Round(KtoF(value), 2).ToString();
            }
            else if(rdbF1.Checked)
            {
                if (rdbC2.Checked)
                    return Math.Round(FtoC(value), 2).ToString();
                else if (rdbK2.Checked)
                    return Math.Round(FtoK(value), 2).ToString();
                else if (rdbF2.Checked)
                    return Math.Round(value, 2).ToString();
            }

            return "";
        }
        public frmTemperatura()
        {
            InitializeComponent();
        }

        private void txtValue1_TextChanged(object sender, EventArgs e)
        {
            if(txtValue1.Text != "")
                txtValue2.Text = Convert(double.Parse(txtValue1.Text));
        }

        private void rdbC1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValue1.Text != "")
                txtValue2.Text = Convert(double.Parse(txtValue1.Text));
        }

        private void rdbK1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValue1.Text != "")
                txtValue2.Text = Convert(double.Parse(txtValue1.Text));
        }

        private void rdbF1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValue1.Text != "")
                txtValue2.Text = Convert(double.Parse(txtValue1.Text));
        }

        private void rdbC2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValue1.Text != "")
                txtValue2.Text = Convert(double.Parse(txtValue1.Text));
        }

        private void rdbK2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValue1.Text != "")
                txtValue2.Text = Convert(double.Parse(txtValue1.Text));
        }

        private void rdbF2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValue1.Text != "")
                txtValue2.Text = Convert(double.Parse(txtValue1.Text));
        }

        private void txtValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
