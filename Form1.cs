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
        bool IsNewNumber = true;
        bool IsActNumber = false;
        char Act = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            if (IsNewNumber)
            {
                Display.Text = "";
                EnableActButtones();
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
            IsNewNumber = false;
            if (IsActNumber)
            {
                ActValue = Display.Text;
            }
        }

        private void ActButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Tmp = Display.Text;
            Act = button.Text[0];
            ActValue = "";
            IsNewNumber = true;
            IsActNumber = true;
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            if (Tmp == "")
            {
                Tmp = Display.Text;
            }
            if (ActValue == "")
            {
                ActValue = Display.Text;
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
                        DisableActButtones();
                        Display.Text = "Деление на ноль невозможно";
                    }
                    else
                    {
                        Display.Text = (Convert.ToDouble(Tmp) / Convert.ToDouble(ActValue)).ToString();
                    }
                    break;
                case ' ':
                    return;
            }
            IsNewNumber = true;
            IsActNumber = false;
            Tmp = "";
        }

        private void NumberSignButton_Click(object sender, EventArgs e)
        {
            Display.Text = (Convert.ToDouble(Display.Text) * -1).ToString();
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            Tmp = "";
            ActValue = "";
            IsActNumber = false;
        }
        private void DisableActButtones()
        {
            plusButton.Enabled = false;
            minusButton.Enabled = false;
            multiplicationButton.Enabled = false;
            divisionButton.Enabled = false;
            NumberSignButton.Enabled = false;
            decimalPointButton.Enabled = false;
            Display.TextAlign = HorizontalAlignment.Center;
        }
        private void EnableActButtones()
        {
            plusButton.Enabled = true;
            minusButton.Enabled = true;
            multiplicationButton.Enabled = true;
            divisionButton.Enabled = true;
            NumberSignButton.Enabled = true;
            decimalPointButton.Enabled = true;
            Display.TextAlign = HorizontalAlignment.Right;
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
            if (IsNewNumber)
            {
                Display.Text = "";
            }
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
            IsNewNumber = false;
        }
    }
}
