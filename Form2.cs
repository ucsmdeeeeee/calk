using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2;
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            if (a == 0)
            {
                label6.Text = ($"x = {Convert.ToString(c / b)}");
            }
            else
            {
                var discriminant = Math.Pow(b, 2) - 4 * a * c;
                if (discriminant < 0)
                {
                    label6.Text = "Квадратное уравнение не имеет корней";
                }
                else
                {
                    if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                    {
                        x1 = -b / (2 * a);
                        label6.Text = ($"x = {Convert.ToString(x1)}");
                    }
                    else if (discriminant > 0) //уравнение имеет два разных корня
                    {
                        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                        label6.Text = ($"x1 = {Convert.ToString(x1)}");
                        label7.Text = ($"x2 = {Convert.ToString(x2)}");
                    }
                }
            }
        }
        public double Equation(double a, double b, double c)
        {
            double x1, x2;
            if (a == 0)
            {
                return c / b;
            }
            else
            {
                var discriminant = Math.Pow(b, 2) - 4 * a * c;


                if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    return x1;
                }

            }
            return 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            label6.Text = string.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            quadraticEquationToolStripMenuItem.Enabled = false;
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            this.Hide();
        }

        private void quadraticEquationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
