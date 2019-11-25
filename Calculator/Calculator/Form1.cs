using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
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
            switch(operationperform)
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
                case "dollar":
                    textBox1.Text = (resultvalue * double.Parse(textBox1.Text) * 0.9).ToString();
                    break;

                default:
                    break;
            }
        }

        private void dollar_click(object sender, EventArgs e)
        {
            /*HIER MOET DOLLAR CONVERSIE KOMEN*/
        }
}
