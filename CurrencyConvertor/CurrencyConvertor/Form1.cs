using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CurrencyConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            String choice;
            Double dollar, res;
            choice = b;
            switch (choice)
            {
                case "USA":
                    dollar = Convert.ToInt64(textBox3.Text);
                    res = dollar * 70;
                    label5.Text = res.ToString();
                    break;
                case "UK":
                    dollar = Convert.ToInt64(textBox3.Text);
                    res = dollar * 80;
                    label5.Text = res.ToString();
                    break;
                case "Russia":
                    dollar = Convert.ToInt64(textBox3.Text);
                    res = dollar * 70;
                    label5.Text = res.ToString();
                    break;
            }
        }
    }
}