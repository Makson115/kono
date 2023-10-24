using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                MessageBox.Show(" d < 0, значит нет корней (есть)");
            }
            if (d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show(" d = 0, корень равен " + x + ".");
            }
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = (-b + Math.Sqrt(d)) / (-2 * a);
                MessageBox.Show(" d=" + d + " 1 корень = " + x1 + " 2 корень = " + x2 + ".");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
