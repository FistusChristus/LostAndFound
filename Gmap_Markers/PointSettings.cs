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
    public partial class PointSettings : Form
    {
        public PointSettings()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = Category.SelectedItem.ToString();
           // MessageBox.Show(selectedState);
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                // dialog.ShowDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ImgPhathText.Text = dialog.FileName;
                    ImgView.ImageLocation = dialog.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Title.Text != "" && Category.Text != "")
            {
                model model = new model();
                Db_Ad.AdList.Last().ImagePath = ImgView.ImageLocation;
                switch (Category.Text)
                {
                    case "Животные":
                        {
                            Db_Ad.AdList.Last().Category = 1;
                            break;
                        }
                    case "Люди":
                        {
                            Db_Ad.AdList.Last().Category = 2;
                            break;
                        }
                    case "Предметы":
                        {
                            Db_Ad.AdList.Last().Category = 3;
                            break;
                        }
                }
                Db_Ad.AdList.Last().Title = Title.Text;
                Db_Ad.AdList.Last().description = Opisanie.Text;
                Db_Ad.AdList.Last().Login = Form1.login;
                Db_Ad.AdList.Last().Type = Form1.flag;

                model.AddPointInDb("use Ad INSERT INTO MapAd VALUES('" + Db_Ad.AdList.Last().PointX + "','" + Db_Ad.AdList.Last().PointY + "','" + Form1.login + "','" + Form1.flag +
                    "'," + Db_Ad.AdList.Last().Category + ",'" + Title.Text + "','" + ImgView.ImageLocation + "','" + Opisanie.Text + "')");
                MessageBox.Show("Успешно добавлено!");
                Close();
            }
            else if (Title.Text == "")
            {

                MessageBox.Show("Введите название!");
            }
            else MessageBox.Show("Категория не выбрана!");
        }

        private void PointSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
