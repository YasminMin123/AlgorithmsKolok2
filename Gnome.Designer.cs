namespace Algor
{
    partial class Gnome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gnome));
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            prevGnome = new Button();
            nextGnome = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(255, 27);
            label1.Name = "label1";
            label1.Size = new Size(241, 28);
            label1.TabIndex = 0;
            label1.Text = "Гномья сортировка";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox1.Location = new Point(27, 242);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(746, 205);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gnome_sort;
            pictureBox1.Location = new Point(27, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(717, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // prevGnome
            // 
            prevGnome.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            prevGnome.ForeColor = SystemColors.ControlDarkDark;
            prevGnome.Location = new Point(27, 512);
            prevGnome.Name = "prevGnome";
            prevGnome.Size = new Size(85, 30);
            prevGnome.TabIndex = 4;
            prevGnome.Text = "Назад";
            prevGnome.UseVisualStyleBackColor = true;
            prevGnome.Click += prevCoctail_Click;
            // 
            // nextGnome
            // 
            nextGnome.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nextGnome.ForeColor = SystemColors.ControlDarkDark;
            nextGnome.Location = new Point(688, 512);
            nextGnome.Name = "nextGnome";
            nextGnome.Size = new Size(85, 30);
            nextGnome.TabIndex = 5;
            nextGnome.Text = "Вперед";
            nextGnome.UseVisualStyleBackColor = true;
            nextGnome.Click += nextGnome_Click;
            // 
            // Gnome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(817, 565);
            Controls.Add(nextGnome);
            Controls.Add(prevGnome);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Gnome";
            Text = "Гномья сортировка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button prevGnome;
        private Button nextGnome;
    }
}