using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double result = 0;
        string operation = string.Empty;
        string firstNum, secondNum;
        bool enterValue = false;
        bool movePosition;
        int xCoordinate, yCoordinate;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsMathOperators(object sender, EventArgs e)
        {
            if (result != 0) buttonIgual.PerformClick();
            else result = Double.Parse(textDisplay1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (textDisplay1.Text != "0")
            {
                textDisplay2.Text = firstNum = $"{result} {operation}";
                textDisplay1.Text = string.Empty;
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            secondNum = textDisplay1.Text;
            textDisplay2.Text = $"{textDisplay2.Text} {textDisplay1.Text} = ";
            if (textDisplay1.Text != string.Empty)
            {
                if (textDisplay1.Text == "0") textDisplay2.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        textDisplay1.Text = (result + double.Parse(textDisplay1.Text)).ToString();
                        break;
                    case "-":
                        textDisplay1.Text = (result - double.Parse(textDisplay1.Text)).ToString();
                        break;
                    case "*":
                        textDisplay1.Text = (result * double.Parse(textDisplay1.Text)).ToString();
                        break;
                    case "/":
                        textDisplay1.Text = (result / double.Parse(textDisplay1.Text)).ToString();
                        break;
                    default: textDisplay2.Text = $"{textDisplay1.Text} = ";
                        break;
                }

                result = double.Parse(textDisplay1.Text);
                operation = string.Empty;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text.Length > 0)
                textDisplay1.Text = textDisplay1.Text.Remove(textDisplay1.Text.Length - 1, 1);
            if (textDisplay1.Text == string.Empty) textDisplay1.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = "0";
            textDisplay2.Text = string.Empty;
            result = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            movePosition = true;
            xCoordinate = e.X;
            yCoordinate = e.Y;
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (movePosition)
            {
                this.SetDesktopLocation(MousePosition.X - xCoordinate, MousePosition.Y - yCoordinate);
            }
        }

        private void mouse_up(object sender, MouseEventArgs e)
        {
            movePosition = false;

        }

        private void buttonNumClick(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0" || enterValue) textDisplay1.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textDisplay1.Text.Contains("."))
                    textDisplay1.Text = textDisplay1.Text + button.Text;
            }
            else textDisplay1.Text = textDisplay1.Text + button.Text;
        }
    }
}
