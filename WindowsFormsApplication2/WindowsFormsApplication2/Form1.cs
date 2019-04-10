using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Double result=0;
        String operater = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }

            Button btn = (Button)sender;
            textBox.Text = textBox.Text + btn.Text;
        }

        private void Operator_click(object sender, MouseEventArgs e)
        {
            if (textBox.Text != string.Empty)
            {
                Button btn = (Button)sender;
                operater = btn.Text;
                result = Double.Parse(textBox.Text);
                textBox.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            switch (operater) {
                case "+":
                   
                    textBox.Text =(Double.Parse(textBox.Text) + result).ToString();
                    break;
                case "-":
                   
                    textBox.Text = (result - Double.Parse(textBox.Text) ).ToString();
                    break;
                case "*":
             
                    textBox.Text = (Double.Parse(textBox.Text) * result).ToString();
                    break;
                case "/":
                  
                    textBox.Text = ( result / Double.Parse(textBox.Text)).ToString();
                    break;
            }
        }
    }
}
