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
    public partial class Form1 : Form
    {

        double PreviousValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            PreviousValue = double.Parse(Output.Text);
            Output.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PreviousValue = double.Parse(Output.Text);
            Output.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PreviousValue = double.Parse(Output.Text);
            Output.Text = "3";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Calculate("PLUS");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Calculate("MINUS");
        }

        private void Calculate(string s)
        {
            if (s.Equals("PLUS"))
            {
                double total = PreviousValue + double.Parse(Output.Text);
                Output.Text = total.ToString();
            }
            else if (s.Equals("MINUS"))
            {
                double total = PreviousValue - double.Parse(Output.Text);
                Output.Text = total.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] parts = Output.Text.Split('+');
            int total = 0;
            foreach (string v in parts) {
                total = total + Convert.ToInt32(v);
            }
            Output.Text = total.ToString();
        }
    }
}
