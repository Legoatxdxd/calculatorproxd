using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isOperationPerformed)
                textBox.Clear();

            isOperationPerformed = false;
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender; // Specify the namespace
            textBox.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender; // Specify the namespace
            operation = button.Text;
            result = double.Parse(textBox.Text);
            isOperationPerformed = true;
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox.Text = (result + double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (result - double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (result * double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(textBox.Text) != 0)
                        textBox.Text = (result / double.Parse(textBox.Text)).ToString();
                    else
                        textBox.Text = "Error"; // Handle divide by zero
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox.Text);
            operation = "";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
            operation = "";
        }
    }
}
