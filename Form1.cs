using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string Tmp = "";
        string ActValue = "";
        bool NewNumber = true;
        char Act = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            if (NewNumber)
            {
                Display.Text = "";
            }
            Button button = (Button)sender;
            if (Display.Text == "0")
            {
                Display.Text = button.Text;
            }
            else
            {
                Display.Text += button.Text;
            }
            NewNumber = false;
        }

        private void ActButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Tmp = Display.Text;
            ActValue = Display.Text;
            Act = button.Text[0];
            NewNumber = true;
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            ActValue = Display.Text;
            if (Tmp == "")
            {
                Tmp = Display.Text;
            }
            switch (Act)
            {
                case '+':
                    Display.Text = (Convert.ToDouble(Tmp) + Convert.ToDouble(ActValue)).ToString();
                    break;
                case '-':
                    Display.Text = (Convert.ToDouble(Tmp) - Convert.ToDouble(ActValue)).ToString();
                    break;
                case '×':
                    Display.Text = (Convert.ToDouble(Tmp) * Convert.ToDouble(ActValue)).ToString();
                    break;
                case '÷':
                    if (Convert.ToDouble(ActValue) == 0)
                    {
                        Display.Text = "Деление на ноль невозможно";
                        DisableActButtones();
                    }
                    else
                    {
                        Display.Text = (Convert.ToDouble(Tmp) / Convert.ToDouble(ActValue)).ToString();
                    }
                    break;
            }
            Tmp = "";
        }

        private void NumberSignButton_Click(object sender, EventArgs e)
        {
            Display.Text = (Convert.ToDouble(Display.Text) * -1).ToString();
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Tmp = "";
            ActValue = "";
        }
        private void DisableActButtones()
        {
            plusButton.Enabled = false;
            minusButton.Enabled = false;
            multiplicationButton.Enabled = false;
            divisionButton.Enabled = false;
            NumberSignButton.Enabled = false;
            decimalPointButton.Enabled = false;
        }
        private void EnableActButtones()
        {
            plusButton.Enabled = true;
            minusButton.Enabled = true;
            multiplicationButton.Enabled = true;
            divisionButton.Enabled = true;
            NumberSignButton.Enabled = true;
            decimalPointButton.Enabled = true;
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }
        }

        private void decimalPointButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "")
            {
                Display.Text = "0,";
            }
            else
            {
                if (!Display.Text.Contains(","))
                {
                    Display.Text += ",";
                }

            }
        }
    }
}
