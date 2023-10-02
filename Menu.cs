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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainmenu = new Form1();
            mainmenu.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            mainmenu.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 mainmenu = new Form3();
            mainmenu.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 mainmenu = new Form4();
            mainmenu.ShowDialog(this);
        }
    }
}
