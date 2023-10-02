using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoy.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() +"+" + y.ToString() +"=" + kq.ToString() + "\r\n";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoy.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "*" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("form2.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();
        }

        private void tbKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
