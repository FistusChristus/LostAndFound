using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gmap_Markers
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.login != null)
            {
                Form1 FindMap = new Form1();
                Form1.flag = true;
                FindMap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Зайдите в учетную запись");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Form1.login != null)
            {
                Form1 LostMap = new Form1();
                Form1.flag = false;
                LostMap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Зайдите в учетную запись");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

    }
}
