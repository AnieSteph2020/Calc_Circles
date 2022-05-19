using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            double radius;
            bool go = double.TryParse(txtRadius.Text, out radius);
            if(go == false)
            {
                MessageBox.Show("No radius :(");
            }
            double circumference = 2.0 * Math.PI * radius;
            double surface = 4.0 * Math.PI * radius * radius;
            double volume = 4.0 / 3.0 * Math.PI * radius * radius * radius;

            txtBoxCircum.Text = circumference.ToString("0.00");
            txtBoxSurf.Text = surface.ToString("0.00");
            txtBoxVol.Text = volume.ToString("0.00");
        }

        private void checkBCircumChecked(object sender, EventArgs e)
        {
            if (chkBoxCircum.Checked == true)
            {
                txtBoxCircum.Visible = true;
            }
            else
            {
                txtBoxCircum.Visible = false;
            }
        }

        private void checkBSurfChecked(object sender, EventArgs e)
        {
            if (chkBoxSurf.Checked == true)
            {
                txtBoxSurf.Visible = true;
            }
            else
            {
                txtBoxSurf.Visible = false;
            }
        }

        private void checkBVolChecked(object sender, EventArgs e)
        {
            if (chkBoxVol.Checked == true)
            {
                txtBoxVol.Visible = true;
            }
            else
            {
                txtBoxVol.Visible = false;
            }
        }
    }
}
