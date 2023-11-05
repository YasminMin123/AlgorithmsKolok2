namespace Algor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HelloText = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            cocktailbtn = new Button();
            gnomebtn = new Button();
            cyclicbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // HelloText
            // 
            HelloText.AutoSize = true;
            HelloText.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            HelloText.ForeColor = SystemColors.WindowFrame;
            HelloText.Location = new Point(186, 35);
            HelloText.Name = "HelloText";
            HelloText.Size = new Size(293, 42);
            HelloText.TabIndex = 0;
            HelloText.Text = "Добро пожаловать!";
            HelloText.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.котейль;
            pictureBox1.Location = new Point(48, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.гном;
            pictureBox2.Location = new Point(237, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngtree_blue_vector_recycle_icon_material_image_2286129;
            pictureBox3.Location = new Point(429, 115);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(147, 180);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // cocktailbtn
            // 
            cocktailbtn.Location = new Point(48, 300);
            cocktailbtn.Name = "cocktailbtn";
            cocktailbtn.RightToLeft = RightToLeft.Yes;
            cocktailbtn.Size = new Size(150, 75);
            cocktailbtn.TabIndex = 5;
            cocktailbtn.Text = "Cocktail Shaker Sort";
            cocktailbtn.UseVisualStyleBackColor = true;
            cocktailbtn.Click += button1_Click;
            // 
            // gnomebtn
            // 
            gnomebtn.Location = new Point(237, 300);
            gnomebtn.Name = "gnomebtn";
            gnomebtn.RightToLeft = RightToLeft.Yes;
            gnomebtn.Size = new Size(143, 75);
            gnomebtn.TabIndex = 6;
            gnomebtn.Text = "Gnome Sort";
            gnomebtn.UseVisualStyleBackColor = true;
            gnomebtn.Click += gnomebtn_Click;
            // 
            // cyclicbtn
            // 
            cyclicbtn.Location = new Point(429, 300);
            cyclicbtn.Name = "cyclicbtn";
            cyclicbtn.RightToLeft = RightToLeft.Yes;
            cyclicbtn.Size = new Size(147, 75);
            cyclicbtn.TabIndex = 7;
            cyclicbtn.Text = "Cyclic Sort";
            cyclicbtn.UseVisualStyleBackColor = true;
            cyclicbtn.Click += cyclicbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 388);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 8;
            label1.Text = "Нажмите на кнопки что бы узнать подробности";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 77);
            label2.Name = "label2";
            label2.Size = new Size(476, 20);
            label2.TabIndex = 9;
            label2.Text = "Это тренажер для изучения школьниками алгоритмов сортировки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(623, 451);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cyclicbtn);
            Controls.Add(gnomebtn);
            Controls.Add(cocktailbtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(HelloText);
            Name = "Form1";
            Text = "Главная страница";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloText;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button cocktailbtn;
        private Button gnomebtn;
        private Button cyclicbtn;
        private Label label1;
        private Label label2;
    }
}