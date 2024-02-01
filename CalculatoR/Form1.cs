using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatoR
{
    public partial class Form1 : Form
    {
        double result = 0;
        string opPerform = "";
        bool isopPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || isopPerformed)
                textBox.Clear();
            isopPerformed = false;
            Button all = (Button)sender;
            if (all.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text = textBox.Text + all.Text;
                }
            }
            else
            {
                textBox.Text = textBox.Text + all.Text;
            }
        }
        private void op_click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            if (result != 0)
            {
                //equal.PerformClick();
                opPerform = op.Text;
                label1.Text = result + " " + opPerform;
                isopPerformed = true;
            }
            else
            {
                opPerform = op.Text;
                result = double.Parse(textBox.Text);
                label1.Text = result + " " + opPerform;
                isopPerformed = true;
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            label1.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (opPerform)
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
                    textBox.Text = (result / double.Parse(textBox.Text)).ToString();
                    break;
            }
            result = double.Parse(textBox.Text);
            label1.Text = "";
        }

        private void mouseHover_Click(object sender, EventArgs e)
        {
            Button change = (Button)sender;
            change.BackColor = Color.Lime;
        }

        private void mouseLeave_Click(object sender, EventArgs e)
        {
            Button change2 = (Button)sender;
            change2.BackColor = Color.Snow;
        }

        private void Clear_MouseHover(object sender, EventArgs e)
        {
            Clear.BackColor = Color.Yellow;
        }

        private void Clear_MouseLeave(object sender, EventArgs e)
        {
            Clear.BackColor = Color.Snow;
        }

        private void buttonC_MouseHover(object sender, EventArgs e)
        {
            buttonC.BackColor = Color.Red;
        }

        private void buttonC_MouseLeave(object sender, EventArgs e)
        {
            buttonC.BackColor = Color.Snow;
        }
    }
}
