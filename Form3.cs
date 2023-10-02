using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            add_Click();
            list = new List<string>();
        }



        List<Button> buttons;
        List<string> list;
        private void add_Click()
        {
            buttons = new List<Button>() { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9};
            foreach (var item in buttons)
            {
                item.Click += new EventHandler(bunton_Click);
            }
        }
        private void bunton_Click(Object sender, EventArgs e)
        {
            string textButton = (sender as Button).Text;//dung as
            textBox1.Text += textButton;
        }

        private void sum()
        {
            if(list.Contains("+"))  //12+3
            {
                list.Remove("+"); //12 3
                double s = Convert.ToDouble(list[0]) + Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void sub()
        {
            if (list.Contains("-"))  //12+3
            {
                list.Remove("-"); //12 3
                double s = Convert.ToDouble(list[0]) - Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }

        private void mul()
        {
            if (list.Contains("*"))  //12+3
            {
                list.Remove("*"); //12 3
                double s = Convert.ToDouble(list[0]) * Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }
        private void div()
        {
            if (list.Contains("/"))  //12+3
            {
                list.Remove("/"); //12 3
                double s = Convert.ToDouble(list[0]) / Convert.ToDouble(list[1]);
                textBox1.Text = s.ToString();
            }
        }





        private void enablebutton()
        {
            btn_Cong.Enabled = true;
            btn_Tru.Enabled = true;
            btn_Nhan.Enabled = true;
            btn_Chia.Enabled = true;
        }
        private void disableButton()
        {
            btn_Cong.Enabled = false;
            btn_Tru.Enabled = false;
            btn_Nhan.Enabled = false;
            btn_Chia.Enabled = false;
        }







        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                 list.Add(textBox1.Text);
                list.Add(btn_Cong.Text);
                textBox1.Text = "";
                disableButton();
            }
        }

        private void btn_Bang_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                list.Add(textBox1.Text);
                sum();
                sub();
                mul();
                div();
                list.Clear();
                enablebutton();
            }
        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                list.Add(btn_Tru.Text);
                textBox1.Text = "";
                disableButton();
            }
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                list.Add(btn_Nhan.Text);
                textBox1.Text = "";
                disableButton();
            }
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                list.Add(textBox1.Text);
                list.Add(btn_Chia.Text);
                textBox1.Text = "";
                disableButton();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            list.Clear();
            enablebutton();
        }
    }
}
