namespace Algor
{
    partial class Cyclic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cyclic));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            prevCoctail = new Button();
            textBox1 = new TextBox();
            nextCyclic = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(250, 31);
            label1.Name = "label1";
            label1.Size = new Size(275, 28);
            label1.TabIndex = 0;
            label1.Text = "Циклическая сортировка";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cycle_sort;
            pictureBox1.Location = new Point(28, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // prevCoctail
            // 
            prevCoctail.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            prevCoctail.ForeColor = SystemColors.ControlDarkDark;
            prevCoctail.Location = new Point(28, 522);
            prevCoctail.Name = "prevCoctail";
            prevCoctail.Size = new Size(85, 30);
            prevCoctail.TabIndex = 5;
            prevCoctail.Text = "Назад";
            prevCoctail.UseVisualStyleBackColor = true;
            prevCoctail.Click += prevCoctail_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox1.Location = new Point(28, 278);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(744, 227);
            textBox1.TabIndex = 6;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // nextCyclic
            // 
            nextCyclic.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nextCyclic.ForeColor = SystemColors.ControlDarkDark;
            nextCyclic.Location = new Point(687, 522);
            nextCyclic.Name = "nextCyclic";
            nextCyclic.Size = new Size(85, 30);
            nextCyclic.TabIndex = 7;
            nextCyclic.Text = "Вперед";
            nextCyclic.UseVisualStyleBackColor = true;
            nextCyclic.Click += nextCyclic_Click;
            // 
            // Cyclic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(834, 564);
            Controls.Add(nextCyclic);
            Controls.Add(textBox1);
            Controls.Add(prevCoctail);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Cyclic";
            Text = "Циклическая сортировка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button prevCoctail;
        private TextBox textBox1;
        private Button nextCyclic;
    }
}