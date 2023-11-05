namespace Algor
{
    partial class Coctail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coctail));
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            prevCoctail = new Button();
            nextCoctail = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(49, 23);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(685, 33);
            label1.TabIndex = 0;
            label1.Text = "Коктейльный или по-другому сортировка перемешением";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(38, 279);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(696, 209);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cocktail_sort;
            pictureBox1.Location = new Point(38, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // prevCoctail
            // 
            prevCoctail.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            prevCoctail.Location = new Point(38, 505);
            prevCoctail.Name = "prevCoctail";
            prevCoctail.Size = new Size(85, 30);
            prevCoctail.TabIndex = 3;
            prevCoctail.Text = "Назад";
            prevCoctail.UseVisualStyleBackColor = true;
            prevCoctail.Click += prevCoctail_Click;
            // 
            // nextCoctail
            // 
            nextCoctail.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nextCoctail.Location = new Point(649, 505);
            nextCoctail.Name = "nextCoctail";
            nextCoctail.Size = new Size(85, 30);
            nextCoctail.TabIndex = 4;
            nextCoctail.Text = "Вперед";
            nextCoctail.UseVisualStyleBackColor = true;
            nextCoctail.Click += button1_Click;
            // 
            // Coctail
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(776, 562);
            Controls.Add(nextCoctail);
            Controls.Add(prevCoctail);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Coctail";
            Text = "Коктейльная сортировка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button prevCoctail;
        private Button nextCoctail;
    }
}