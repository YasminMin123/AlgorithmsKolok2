namespace Algor
{
    partial class MainAl
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
            textBox1 = new TextBox();
            btnSort = new Button();
            btnGoHome = new Button();
            cbCoctail = new CheckBox();
            cbGnom = new CheckBox();
            cbCyclic = new CheckBox();
            tbOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(68, 304);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(138, 29);
            btnSort.TabIndex = 1;
            btnSort.Text = "Отсортировать";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnGoHome
            // 
            btnGoHome.Location = new Point(625, 379);
            btnGoHome.Name = "btnGoHome";
            btnGoHome.Size = new Size(126, 29);
            btnGoHome.TabIndex = 2;
            btnGoHome.Text = "На главную";
            btnGoHome.UseVisualStyleBackColor = true;
            btnGoHome.Click += btnGoHome_Click;
            // 
            // cbCoctail
            // 
            cbCoctail.AutoSize = true;
            cbCoctail.Location = new Point(48, 153);
            cbCoctail.Name = "cbCoctail";
            cbCoctail.Size = new Size(205, 24);
            cbCoctail.TabIndex = 3;
            cbCoctail.Text = "Коктейльная сортировка";
            cbCoctail.UseVisualStyleBackColor = true;
            cbCoctail.CheckedChanged += cbCoctail_CheckedChanged;
            // 
            // cbGnom
            // 
            cbGnom.AutoSize = true;
            cbGnom.Location = new Point(47, 193);
            cbGnom.Name = "cbGnom";
            cbGnom.Size = new Size(168, 24);
            cbGnom.TabIndex = 4;
            cbGnom.Text = "Гномья сортировка";
            cbGnom.UseVisualStyleBackColor = true;
            cbGnom.CheckedChanged += cbGnom_CheckedChanged;
            // 
            // cbCyclic
            // 
            cbCyclic.AutoSize = true;
            cbCyclic.Location = new Point(47, 232);
            cbCyclic.Name = "cbCyclic";
            cbCyclic.Size = new Size(206, 24);
            cbCyclic.TabIndex = 5;
            cbCyclic.Text = "Циклическая сортировка";
            cbCyclic.UseVisualStyleBackColor = true;
            cbCyclic.CheckedChanged += cbCyclic_CheckedChanged;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(273, 261);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(478, 27);
            tbOutput.TabIndex = 6;
            tbOutput.TextChanged += tbOutput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 47);
            label1.Name = "label1";
            label1.Size = new Size(446, 20);
            label1.TabIndex = 7;
            label1.Text = "Тут мы запускаем сортировки и проверяем как они работают ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 113);
            label2.Name = "label2";
            label2.Size = new Size(320, 20);
            label2.TabIndex = 14;
            label2.Text = "Введите 10 рандомных чисел, через пробел:";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 223);
            label3.Name = "label3";
            label3.Size = new Size(359, 20);
            label3.TabIndex = 15;
            label3.Text = "Тут отображается отсортированный список чисел";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 346);
            label4.Name = "label4";
            label4.Size = new Size(753, 20);
            label4.TabIndex = 16;
            label4.Text = "После того как выбрали тип сортировки. Нажмите на кнопку \"Отсортировать\", чтобы алгоритм заработал";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 113);
            label5.Name = "label5";
            label5.Size = new Size(195, 20);
            label5.TabIndex = 17;
            label5.Text = "Выберите тип сортировки:";
            // 
            // MainAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbOutput);
            Controls.Add(cbCyclic);
            Controls.Add(cbGnom);
            Controls.Add(cbCoctail);
            Controls.Add(btnGoHome);
            Controls.Add(btnSort);
            Controls.Add(textBox1);
            Name = "MainAl";
            Text = "Реализация алгоритмов";
            Load += MainAl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnSort;
        private Button btnGoHome;
        private CheckBox cbCoctail;
        private CheckBox cbGnom;
        private CheckBox cbCyclic;
        private TextBox tbOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}