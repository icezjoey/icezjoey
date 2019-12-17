using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frame : Form
    {
        double resultvalue = 0;
        string operationperform = "";
        bool remember = false;

        public frame()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || remember)
                textBox1.Clear();

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
            remember = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperform = button.Text;
            resultvalue = double.Parse(textBox1.Text);
            labelcurrentoperation.Text = resultvalue + " " + operationperform;
            remember = true;
        }

        private void buttonac_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultvalue = 0;
        }

        private void buttonenter_click(object sender, EventArgs e)
        {
            switch (operationperform)
            {
                case "+":
                    textBox1.Text = (resultvalue + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultvalue - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultvalue * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultvalue / double.Parse(textBox1.Text)).ToString();
                    break;
                case "DOLLAR":
                    textBox1.Text = (resultvalue * 0.90812).ToString();
                    break;
                case "EURO":
                    textBox1.Text = (resultvalue * 1.1006).ToString();
                    break;
            }
        }

        //naar dollar conversie
        private void dollar_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperform = button.Text;
            resultvalue = double.Parse(textBox1.Text);
            labelcurrentoperation.Text = resultvalue + " Naar " + operationperform;
            remember = true;

        }

        //naar Euro conversie
        private void euro_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperform = button.Text;
            resultvalue = double.Parse(textBox1.Text);
            labelcurrentoperation.Text = resultvalue + " Naar " + operationperform;
            remember = true;
        }

        //Modular conversie
        private void Modular_Click(object sender, EventArgs e)
        {
            int mod = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(mod, 8);
        }

        //hexadicmal conversie
        private void Hexa_Click(object sender, EventArgs e)
        {
            int hex = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(hex, 16);
        }


        //binary conversie
        private void Binary_Click(object sender, EventArgs e)
        {
            int bin = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(bin, 2);
        }
    }
}