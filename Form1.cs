namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double GetValueA()
        {
            return double.Parse(textBox1.Text);
        }

        public double GetValueB()
        {
            return double.Parse(textBox2.Text);
        }

        public void DisplayResult(double result)
        {
            label2.Text = result.ToString();
        }
        public double Add(double a, double b)
        {
            double c = a + b;
            DisplayResult(c);
            return c;
        }
        public double Sub(double a, double b)
        {
            double c = a - b;
            DisplayResult(c);
            return c;
        }
        public double Div(double a, double b)
        {

            if (b == 0)
            {
                throw new ArgumentException("На ноль делить нельзя");
            }
            double c = a / b;
            DisplayResult(c);
            return c;
        }
        public double Mul(double a, double b)
        {

            double c = a * b;
            DisplayResult(c);
            return c;
        }
        public double Log(double a)
        {
            double c = Math.Log(a);
            DisplayResult(c);
            return c;
        }
        public double Sqrt(double a)
        {
            double c = Math.Sqrt(a);
            DisplayResult(c);
            return c;
        }
        public double PI()
        {
            double c = Math.PI;
            DisplayResult(c);
            return c;
        }
        public double Average(double a,double b)
        {
            double c = (a+b)/2;
            DisplayResult(c);
            return c;
        }
        public double Sin(double a)
        {
            double c = Math.Sin(a * (Math.PI / 180.0));
            DisplayResult(c);
            return c;
        }
        public double Cos(double a)
        {
            double c = Math.Cos(a * (Math.PI / 180.0));
            DisplayResult(c);
            return c;
        }
        public double Tg(double a)
        {
            double c = Math.Tan(a * (Math.PI / 180.0));
            DisplayResult(c);
            return c;
        }
        public double Exp(double a)
        {
            double c = Math.Exp(a);
            DisplayResult(c);
            return c;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Add(a, b);
            DisplayResult(c);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Sub(a, b);
            DisplayResult(c);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Mul(a, b);
            DisplayResult(c);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Div(a, b);
            DisplayResult(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Log(a);
            DisplayResult(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Sin(a);
            DisplayResult(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Cos(a);
            DisplayResult(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Tg(a);
            DisplayResult(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Exp(a);
            DisplayResult(c);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            DisplayResult(Math.Sqrt(a));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double c = Math.PI;
            DisplayResult(c);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label2.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculaotrToolStripMenuItem.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = (a + b) / 2;
            DisplayResult(c);
        }

        private void calculaotrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void qEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
