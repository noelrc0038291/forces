using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI); 
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
               
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double force, angle;
            try
            {
                force = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for force.");
                force = 0.0;
            }
            try
            {
                angle = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect value for angle.");
                angle = 0.0;
            }

            double Fx = force * cos(angle);
            label1.Text = "Fx = " + Fx + " N";

            double Fy = force * sin(angle);
            label2.Text = "Fy = " + Fy + " N";

        }
    }
}
