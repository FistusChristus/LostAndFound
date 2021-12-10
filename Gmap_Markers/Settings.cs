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
    public partial class Settings : Form
    {
        internal static Db_Ad Item= new Db_Ad();
        public Settings()
        {
            InitializeComponent();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Item.ImagePath;
            itemName.Text = Item.Title;
            login.Text = Item.Login;
            if (Item.Type)
            {
                type.Text = "Найдено";
            }
            else
            {
                type.Text = "Потеряно";
            }
            switch (Item.Category)
            {
                case 1:
                    category.Text = "Животные";
                    break;
                case 2:
                    category.Text = "Люди";
                    break;
                case 3:
                    category.Text = "Предметы";
                    break;
            }
            richTextBox1.Text = Item.description;

        }

        private void type_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Item.Login == Form1.login)
            {
                model model = new model();
                Db_Ad.AdList.Remove(Item);
                model.delete("DELETE FROM MapAd WHERE id = " + Item.id);
                MessageBox.Show("Удалено успешно!");
                Close();
            }
            else MessageBox.Show("Это не ваше объявление!");
            
        }
    }
}
