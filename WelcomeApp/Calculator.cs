using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeApp;

public partial class Calculator : Form
{
    int? num1;
    int? num2;
    string operation = "";
    int? result;
    //string? minus;
    public Calculator()
    {
        InitializeComponent();
    }
    private void valueButton_Click(object sender, EventArgs e)
    {
        if (result != null) cleanCalc(sender, e);

        Button currentButton = sender as Button;
        string buttonValue = currentButton.Text;

        if (string.IsNullOrEmpty(operation))
        {
            if (num1 == null || num1 == 0)
            {
                if (num1 == 0 && outputTextBox.Text.Length != 0) outputTextBox.Text = outputTextBox.Text.Substring(0, outputTextBox.Text.Length - 1);
                num1 = int.Parse(buttonValue);
                //if (minus == "-") num1 = 0 - num1;
            }
            else
            {
                num1 = int.Parse(num1.Value.ToString() + buttonValue);
            }
        }
        else
        {
            if (num2 == null || num2 == 0)
            {
                if (num2 == 0 && outputTextBox.Text.Length != 0) outputTextBox.Text = outputTextBox.Text.Substring(0, outputTextBox.Text.Length - 1);
                num2 = int.Parse(buttonValue);
            }
            else
            {
                num2 = int.Parse(num2.Value.ToString() + buttonValue);
            }
        }

        outputTextBox.Text += buttonValue;
    }
    private void operationButton_Click(object sender, EventArgs e)
    {
        Button currentButton = sender as Button;

        //if (string.IsNullOrEmpty(outputTextBox.Text)
        //        && currentButton.Text == "-")
        //{
        //    minus = "-";
        //}

        if (result != null
            || !string.IsNullOrEmpty(operation)
            || string.IsNullOrEmpty(outputTextBox.Text)
            )
        {
            cleanCalc(sender, e);
            return;
        }

        operation = currentButton.Text;
        outputTextBox.Text += " " + operation + " ";
    }
    private void equalsButton_Click(object sender, EventArgs e)
    {
        if (num1 == null
            || num2 == null
            || string.IsNullOrEmpty(operation))
        {
            cleanCalc(sender, e);
            return;
        }

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
            default:
                break;
        }
        outputTextBox.Text += " = " + result.ToString();
    }
    private void cleanCalc(object sender, EventArgs e)
    {
        num1 = null;
        num2 = null;
        operation = "";
        result = null;
        outputTextBox.Text = "";
    }
}
