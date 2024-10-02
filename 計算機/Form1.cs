using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機
{
    public partial class Form1 : Form
    {
        private string formula = "";
        private readonly string[] disallow = { "+", "-", "/", "*" };

        private bool lastInput = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void update_display()
        {
            Answer.Text = formula;
        }

        static double Eval(string expression)
        {
            DataTable table = new DataTable();
            // Compute メソッドで数式を評価
            object result = table.Compute(expression, string.Empty);
            return Convert.ToDouble(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formula += "1";
            update_display();
            lastInput = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formula += "2";
            update_display();
            lastInput = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formula += "3";
            update_display();
            lastInput = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formula += "4";
            update_display();
            lastInput = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formula += "5";
            update_display();
            lastInput = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formula += "6";
            update_display();
            lastInput = true;
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            formula += "7";
            update_display();
            lastInput = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formula += "8";
            update_display();
            lastInput = true;
        }

        void button9_Click(object sender, EventArgs e)
        {
            formula += "9";
            update_display();
            lastInput = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            formula += "0";
            update_display();
            lastInput = true;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (lastInput)
            {
                formula += "+";
                update_display();
                lastInput = false;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (lastInput)
            {
                formula += "-";
                update_display();
                lastInput = false;
            }

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (lastInput)
            {
                formula += "*";
                update_display();
                lastInput = false;
            }
        }

        private void split_Click(object sender, EventArgs e)
        {
            if (lastInput)
            {
                formula += "/";
                update_display();
                lastInput = false;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            formula = Eval(formula).ToString();
            update_display();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            formula = "";
            Answer.Text = "計算式";
        }
    }
}
