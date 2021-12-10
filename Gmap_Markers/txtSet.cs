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
    public partial class txtSet : Form
    {
        public txtSet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            update();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSet_Load(object sender, EventArgs e)
        {
            update();

        }

        private void update()
        {
            listBox1.Items.Clear();
            foreach (var item in Db_Ad.AdList)
            {
                listBox1.Items.Add(item.Title);

            }
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {

            //foreach (var item in Db_Ad.AdList)
            //{
            //    if (item.Title == listBox1.SelectedItem.ToString())
            //        ImgBox.ImageLocation = item.ImagePath;
            //}
           
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var item in Db_Ad.AdList)
            {
                if (item.Title == listBox1.SelectedItem.ToString())
                {
                    ImgBox.ImageLocation = item.ImagePath;
                    Settings.Item=item;
                }
            }
        }

        private void category1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Db_Ad.AdList)
            {
                if (item.Category == 1)
                {
                    listBox1.Items.Add(item.Title);
                }
            }
        }

        private void category2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Db_Ad.AdList)
            {
                if (item.Category == 2)
                {
                    listBox1.Items.Add(item.Title);
                }
            }
        }

        private void category3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Db_Ad.AdList)
            {
                if (item.Category == 3)
                {
                    listBox1.Items.Add(item.Title);
                }
            }
            
        }
    }
}
