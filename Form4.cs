﻿using System;
using System.Collections;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public ArrayList GetData(){
            ArrayList lst = new ArrayList();


            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add( f );

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Ngoại ngữ";
            f.Quantity = 2200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K04";
            f.Name = "Cơ khí động lực";
            f.Quantity = 3200;
            lst.Add(f);
            return lst;
        }





        private void Form4_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Id";
            string id = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có mã : "+ id;
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
