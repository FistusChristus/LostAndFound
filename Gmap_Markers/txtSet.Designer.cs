namespace Gmap_Markers
{
    partial class txtSet
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.enter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.category3 = new System.Windows.Forms.RadioButton();
            this.category2 = new System.Windows.Forms.RadioButton();
            this.category1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 135);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 436);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            this.listBox1.Enter += new System.EventHandler(this.listBox1_Enter);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(591, 592);
            this.enter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(255, 106);
            this.enter.TabIndex = 1;
            this.enter.Text = "Открыть";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 592);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(335, 106);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImgBox
            // 
            this.ImgBox.Location = new System.Drawing.Point(348, 5);
            this.ImgBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(497, 567);
            this.ImgBox.TabIndex = 3;
            this.ImgBox.TabStop = false;
            // 
            // category3
            // 
            this.category3.AutoSize = true;
            this.category3.Location = new System.Drawing.Point(17, 94);
            this.category3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.category3.Name = "category3";
            this.category3.Size = new System.Drawing.Size(95, 21);
            this.category3.TabIndex = 4;
            this.category3.TabStop = true;
            this.category3.Text = "предметы";
            this.category3.UseVisualStyleBackColor = true;
            this.category3.CheckedChanged += new System.EventHandler(this.category3_CheckedChanged);
            // 
            // category2
            // 
            this.category2.AutoSize = true;
            this.category2.Location = new System.Drawing.Point(17, 65);
            this.category2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.category2.Name = "category2";
            this.category2.Size = new System.Drawing.Size(65, 21);
            this.category2.TabIndex = 5;
            this.category2.TabStop = true;
            this.category2.Text = "Люди";
            this.category2.UseVisualStyleBackColor = true;
            this.category2.CheckedChanged += new System.EventHandler(this.category2_CheckedChanged);
            // 
            // category1
            // 
            this.category1.AutoSize = true;
            this.category1.Location = new System.Drawing.Point(17, 37);
            this.category1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(98, 21);
            this.category1.TabIndex = 6;
            this.category1.TabStop = true;
            this.category1.Text = "Животные";
            this.category1.UseVisualStyleBackColor = true;
            this.category1.CheckedChanged += new System.EventHandler(this.category1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фильтр по категориям";
            // 
            // txtSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(852, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category1);
            this.Controls.Add(this.category2);
            this.Controls.Add(this.category3);
            this.Controls.Add(this.ImgBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "txtSet";
            this.Text = "Список";
            this.Load += new System.EventHandler(this.txtSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.RadioButton category3;
        private System.Windows.Forms.RadioButton category2;
        private System.Windows.Forms.RadioButton category1;
        private System.Windows.Forms.Label label1;
    }
}