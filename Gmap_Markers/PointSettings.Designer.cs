namespace Gmap_Markers
{
    partial class PointSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImgPhathText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Opisanie = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.ComboBox();
            this.ImgView = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgView)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(16, 34);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(184, 22);
            this.Title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Путь к картинке";
            // 
            // ImgPhathText
            // 
            this.ImgPhathText.Location = new System.Drawing.Point(16, 95);
            this.ImgPhathText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImgPhathText.Name = "ImgPhathText";
            this.ImgPhathText.Size = new System.Drawing.Size(184, 22);
            this.ImgPhathText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Opisanie
            // 
            this.Opisanie.Location = new System.Drawing.Point(16, 196);
            this.Opisanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Opisanie.Name = "Opisanie";
            this.Opisanie.Size = new System.Drawing.Size(219, 242);
            this.Opisanie.TabIndex = 6;
            this.Opisanie.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Животные",
            "Люди",
            "Предметы"});
            this.Category.Location = new System.Drawing.Point(16, 146);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(184, 24);
            this.Category.TabIndex = 8;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ImgView
            // 
            this.ImgView.Location = new System.Drawing.Point(244, 15);
            this.ImgView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImgView.Name = "ImgView";
            this.ImgView.Size = new System.Drawing.Size(412, 295);
            this.ImgView.TabIndex = 9;
            this.ImgView.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 121);
            this.button2.TabIndex = 10;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 318);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 121);
            this.button3.TabIndex = 11;
            this.button3.Text = "Выйти";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PointSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ImgView);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Opisanie);
            this.Controls.Add(this.ImgPhathText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PointSettings";
            this.Text = "Создание";
            this.Load += new System.EventHandler(this.PointSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ImgPhathText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Opisanie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.PictureBox ImgView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}