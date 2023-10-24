using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form3 : Form
    {
        double b, str = 0, sum;
        string a, a1, a2, b2, choice = "", choice1 = "";
        int from, to, b1;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "C";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "A";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "B";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "D";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "E";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "F";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result(); // знак =
        }
        private void result()
        {
            a = "";
            a1 = "";
            a2 = "";
            b2 = "";
            b1 = 0;
            b = 0;
            str = 0;
            sum = 0;
            a = textBox1.Text;
            textBox1.Clear();
            if (from == 2 && to == 10) // из двоичной в десятичную
            {
                for (int i = 0, n = a.Length - 1; i < a.Length; i++, n--)
                {
                    b = Convert.ToDouble(a[i].ToString());
                    if (b != 0 && b != 1)
                    {
                        textBox1.Text = a + " это число не двоичное число";
                    }
                    str += b * Math.Pow(2, n);
                    if (n != 0)
                    {
                        textBox1.Text += b + "*2^" + n + " + ";
                    }
                    else
                    {
                        textBox1.Text += b + "*2^" + n + " = " + str;
                    }
                }
            }
            else if (from == 10 && to == 2) // из десятичной в двоичную
            {
                b1 = Convert.ToInt32(a);
                while (b1 != 0)
                {
                    sum = b1 % 2;
                    b1 = b1 / 2;
                    a2 += Convert.ToString(sum);
                }
                for (int i = a2.Length - 1; i >= 0; i--)
                {
                    a1 += a2[i];
                }
                textBox1.Text = a1;
            }
            else if (from == 2 && to == 8) // из двоичной в восьмиричную
            {
                for (int i = 0, n = a.Length - 1; i < a.Length; i++, n--)
                {
                    b = Convert.ToDouble(a[i].ToString());
                    if (b != 0 && b != 1)
                    {
                        textBox1.Text = a + " это число не двоичное число";
                    }
                    str += b * Math.Pow(2, n);
                    if (n != 0)
                    {
                        textBox1.Text += b + "*2^" + n + " + ";
                    }
                    else
                    {
                        textBox1.Text += b + "*2^" + n + " = " + str;
                    }
                }
                b1 = Convert.ToInt32(str);
                while (b1 != 0)
                {
                    sum = b1 % 8;
                    b1 = b1 / 8;
                    a2 += Convert.ToString(sum);
                }
                for (int i = a2.Length - 1; i >= 0; i--)
                {
                    a1 += a2[i];
                }
                textBox1.Text += " переводим в восьмиричную " + a1;
            }
            else if (from == 8 && to == 2) // из восьмиричной в двоичную
            {
                for (int i = 0, n = a.Length - 1; i < a.Length; i++, n--)
                {
                    b = Convert.ToDouble(a[i].ToString());
                    str += b * Math.Pow(8, n);
                    if (n != 0)
                    {
                        textBox1.Text += b + "*8^" + n + " + ";
                    }
                    else
                    {
                        textBox1.Text += b + "*8^" + n + " = " + str;
                    }
                }
                b1 = Convert.ToInt32(str);
                while (b1 != 0)
                {
                    sum = b1 % 2;
                    b1 = b1 / 2;
                    a2 += Convert.ToString(sum);
                }
                for (int i = a2.Length - 1; i >= 0; i--)
                {
                    a1 += a2[i];
                }
                textBox1.Text += " переводим в двоичную " + a1;
            }
            else if (from == 8 && to == 10) // из восьмиричной в десятичную
            {
                for (int i = 0, n = a.Length - 1; i < a.Length; i++, n--)
                {
                    b = Convert.ToDouble(a[i].ToString());
                    str += b * Math.Pow(8, n);
                    if (n != 0)
                    {
                        textBox1.Text += b + "*8^" + n + " + ";
                    }
                    else
                    {
                        textBox1.Text += b + "*8^" + n + " = " + str;
                    }
                }
            }
            else if (from == 10 && to == 8) // из десятичной в восьмиричную
            {
                b1 = Convert.ToInt32(a);
                while (b1 != 0)
                {
                    sum = b1 % 8;
                    b1 = b1 / 8;
                    a2 += Convert.ToString(sum);
                }
                for (int i = a2.Length - 1; i >= 0; i--)
                {
                    a1 += a2[i];
                }
                textBox1.Text = a1;
            }
            else if (from == 16 || to == 16)
            {
                if (from == 16)
                {
                    for (int i = 0, n = a.Length - 1; i < a.Length; i++, n--)
                    {
                        b2 = Convert.ToString(a[i]);
                        if (b2 == "A" || b2 == "B" || b2 == "C" || b2 == "D" || b2 == "E" || b2 == "F")
                        {
                            switch (b2)
                            {
                                case "A":
                                    b = 10;
                                    break;
                                case "B":
                                    b = 11;
                                    break;
                                case "C":
                                    b = 12;
                                    break;
                                case "D":
                                    b = 13;
                                    break;
                                case "E":
                                    b = 14;
                                    break;
                                case "F":
                                    b = 15;
                                    break;
                            }
                        }
                        else
                        {
                            b = Convert.ToDouble(a[i].ToString());
                        }
                        str += b * Math.Pow(16, n); // из шестнадцатеричной в десятичную
                        if (n != 0)
                        {
                            textBox1.Text += b + "*16^" + n + " + ";
                        }
                        else
                        {
                            textBox1.Text += b + "*16^" + n + " = " + str;
                        }
                    }
                    if (to == 2) // из шестнадцатеричной в двоичную
                    {
                        b = Convert.ToInt32(str);
                        while (b != 0)
                        {
                            sum = b % 2;
                            b = b / 2;
                            a2 += Convert.ToString(sum);
                        }
                        for (int i = a2.Length - 1; i >= 0; i--)
                        {
                            a1 += a2[i];
                        }
                        textBox1.Text += " переводим в двоичную " + a1;
                    }
                    else if (to == 8) // из шестнадцатеричной в восьмеричную
                    {
                        b = Convert.ToInt32(str);
                        while (b != 0)
                        {
                            sum = b % 8;
                            b = b / 8;
                            a2 += Convert.ToString(sum);
                        }
                        for (int i = a2.Length - 1; i >= 0; i--)
                        {
                            a1 += a2[i];
                        }
                        textBox1.Text += " переводим в восьмеричную " + a1;
                    }
                }
                else if (to == 16)
                {
                    if (from == 2) // из двоичной в шестнадцатеричную
                    {
                        for (int i = 0, n = a.Length - 1; i < a.Length; i++, n--)
                        {
                            b = Convert.ToDouble(a[i].ToString());
                            if (b != 0 && b != 1)
                            {
                                textBox1.Text = a + " это число не двоичное число";
                            }
                            str += b * Math.Pow(2, n);
                            if (n != 0)
                            {
                                textBox1.Text += b + "*2^" + n + " + ";
                            }
                            else
                            {
                                textBox1.Text += b + "*2^" + n + " = " + str;
                            }
                        }
                        b1 = Convert.ToInt32(str);
                        while (b1 != 0)
                        {
                            sum = b1 % 16;
                            b1 = b1 / 16;
                            b2 = Convert.ToString(sum);
                            if (b2 == "10" || b2 == "11" || b2 == "12" || b2 == "13" || b2 == "14" || b2 == "15")
                            {
                                switch (b2)
                                {
                                    case "10":
                                        a2 += "A";
                                        break;
                                    case "11":
                                        a2 += "B";
                                        break;
                                    case "12":
                                        a2 += "C";
                                        break;
                                    case "13":
                                        a2 += "D";
                                        break;
                                    case "14":
                                        a2 += "E";
                                        break;
                                    case "15":
                                        a2 += "F";
                                        break;
                                }
                            }
                            else
                            {
                                a2 += Convert.ToString(sum);
                            }
                        }
                        for (int i = a2.Length - 1; i >= 0; i--)
                        {
                            a1 += a2[i];
                        }
                        textBox1.Text += " переводим в шестнадцатеричную " + a1;
                    }
                    else if (from == 8) // из восьмеричной в шестнадцатеричную
                    {
                        for (int i = 0, n = a.Length - 1; i < a.Length; i++, n--)
                        {
                            b = Convert.ToDouble(a[i].ToString());
                            str += b * Math.Pow(8, n);
                            if (n != 0)
                            {
                                textBox1.Text += b + "*8^" + n + " + ";
                            }
                            else
                            {
                                textBox1.Text += b + "*8^" + n + " = " + str;
                            }
                        }
                        b1 = Convert.ToInt32(str);
                        while (b1 != 0)
                        {
                            sum = b1 % 16;
                            b1 = b1 / 16;
                            b2 = Convert.ToString(sum);
                            if (b2 == "10" || b2 == "11" || b2 == "12" || b2 == "13" || b2 == "14" || b2 == "15")
                            {
                                switch (b2)
                                {
                                    case "10":
                                        a2 += "A";
                                        break;
                                    case "11":
                                        a2 += "B";
                                        break;
                                    case "12":
                                        a2 += "C";
                                        break;
                                    case "13":
                                        a2 += "D";
                                        break;
                                    case "14":
                                        a2 += "E";
                                        break;
                                    case "15":
                                        a2 += "F";
                                        break;
                                }
                            }
                            else
                            {
                                a2 += Convert.ToString(sum);
                            }
                        }
                        for (int i = a2.Length - 1; i >= 0; i--)
                        {
                            a1 += a2[i];
                        }
                        textBox1.Text += " переводим в шестнадцатеричную " + a1;
                    }
                    else if (from == 10) // из десятичной в шестнадцатеричную
                    {
                        b1 = Convert.ToInt32(a);
                        while (b1 != 0)
                        {
                            sum = b1 % 16;
                            b1 = b1 / 16;
                            b2 = Convert.ToString(sum);
                            if (b2 == "10" || b2 == "11" || b2 == "12" || b2 == "13" || b2 == "14" || b2 == "15")
                            {
                                switch (b2)
                                {
                                    case "10":
                                        a2 += "A";
                                        break;
                                    case "11":
                                        a2 += "B";
                                        break;
                                    case "12":
                                        a2 += "C";
                                        break;
                                    case "13":
                                        a2 += "D";
                                        break;
                                    case "14":
                                        a2 += "E";
                                        break;
                                    case "15":
                                        a2 += "F";
                                        break;
                                }
                            }
                            else
                            {
                                a2 += b2;
                            }
                        }
                        for (int i = a2.Length - 1; i >= 0; i--)
                        {
                            a1 += a2[i];
                        }
                        textBox1.Text += " переводим в шестнадцатеричную " + a1;
                    }
                }
            }
            else
            {
                textBox1.Text = a;
            }
            from = 0;
            to = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(choice[1]) != "2")
                to = 2;
                choice += "2";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            from = 0;
            from = 10;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            from = 0;
            from = 8;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            to = 0;
            to = 10;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            to = 0;
            to = 8;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            from = 0;
            from = 2;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            from = 0;
            to = 0;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            from = 0;
            from = 16;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            to = 0;
            to = 16;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
