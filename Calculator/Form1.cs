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
    public partial class calculatorForm : Form
    {
        private double firstNumber, secondNumber;

        public calculatorForm()
        {
            InitializeComponent();
            resultsLabel.Text = "";
        }

        private void closeForm(object sender, EventArgs e)
        {
            quitScreen QScreen = new quitScreen();
            QScreen.ShowDialog();
            System.Threading.Thread.Sleep(1000);
            QScreen.Close();
        }

        private void startUpScreen(object sender, EventArgs e)
        {
            startUpSplashScreen SScrean = new startUpSplashScreen();
            SScrean.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            SScrean.Close();
        }

        private void clearTextBoxes(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
        }

        private void powerNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultsLabel.Text = (Math.Pow(firstNumber, secondNumber)).ToString();
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultsLabel.Text = ((firstNumber + secondNumber) / 2).ToString();
        }

        private void subtractingNumbers(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultsLabel.Text = (firstNumber - secondNumber).ToString();
        }

        private void MultiplyingNumbers(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultsLabel.Text = (firstNumber * secondNumber).ToString();
        }

        private void dividingNumbers(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultsLabel.Text = (firstNumber / secondNumber).ToString();
        }

        private void addingNumbers(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultsLabel.Text = (firstNumber + secondNumber).ToString();
        }
    }
}
