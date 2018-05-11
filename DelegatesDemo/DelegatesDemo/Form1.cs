using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.button3.Click += Hakan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateNumbers(AddNumbers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateNumbers(SubtractNumbers);
        }

        delegate int CalculationDelegate(int x, int y);

        void CalculateNumbers(CalculationDelegate functie)
        {
            int x = int.Parse(txtNumber1.Text);
            int y = int.Parse(txtNumber2.Text);

            int answer = functie(x, y);

            label3.Text = $"The answer is: {answer}.";

        }



        // Some calculation functions:

        int AddNumbers(int x, int y)
        {
            return x + y;
        }
        int SubtractNumbers(int x, int y)
        {
            return x - y;
        }
        int MultiplyNumbers(int x, int y)
        {
            return x * y;
        }
        int DivideNumbers(int x, int y)
        {
            return x / y;
        }

        int Square(int x)
        {
            return x * x;
        }

        private void Marijn(object sender, EventArgs e)
        {
            MessageBox.Show("Vanuit functie Marijn");
        }

        private void Hakan(object sender, EventArgs e)
        {
            MessageBox.Show("Vanuit functie Hakan");
        }

        delegate void XandersEventHandler(object sender, EventArgs e);

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
