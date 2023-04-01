using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);


                double radius = Math.Sqrt(x * x + y * y);
                double angle = Math.Atan2(y, x);


                textBox3.Text = radius.ToString();
                textBox4.Text = angle.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for the real and imaginary parts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBox5.Clear();
                textBox6.Clear();
            }
        }
    }
}
