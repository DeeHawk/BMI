using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        double height = 0;
        double weight = 0;
        double BMI =0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtBMI.BackColor = Color.White;

            height = Double.Parse(txtHeight.Text);
            weight = Double.Parse(txtWeight.Text);

            BMI = weight / (height * height) * 703;
            txtBMI.Text = String.Format("{0:f}", BMI);

           

            string BMI_description = string.Empty;

            if ( BMI < 18.5)
            {
                txtBMI.BackColor = Color.Pink;
                lblMsg.Text = "You are underweight.";
            }

            else if (BMI <= 24.9)
            {
                txtBMI.BackColor = Color.LightSeaGreen;
                lblMsg.Text = "Congrats! You have healthy weight.";
            }

            else if (BMI <= 29.9)
            {
                txtBMI.BackColor = Color.Yellow;
                lblMsg.Text = "You are overweight.";
            }
            else if (BMI <= 34.9)
            {
                txtBMI.BackColor = Color.OrangeRed;
                lblMsg.Text = "You are obese!";
            }
            else if (BMI >= 40)
            {
                txtBMI.BackColor = Color.Red;
                lblMsg.Text = "Alert! Morbid obesity.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            txtBMI.Clear();
            lblMsg.Text = "";
            txtBMI.Text = "";
            txtBMI.BackColor = Color.White;

        }
    }
}