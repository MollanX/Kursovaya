namespace Kurs
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            panel1 = new Panel();
            button5 = new Button();
            button6 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 1;
            label1.Text = "Введите данные";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(477, 9);
            label2.Name = "label2";
            label2.Size = new Size(245, 23);
            label2.TabIndex = 2;
            label2.Text = "Методы принятия решений";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(363, 195);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(270, 273);
            button1.Name = "button1";
            button1.Size = new Size(123, 36);
            button1.TabIndex = 4;
            button1.Text = "Очистка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(27, 273);
            button2.Name = "button2";
            button2.Size = new Size(235, 36);
            button2.TabIndex = 5;
            button2.Text = "Случайные данные";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(761, 397);
            button3.Name = "button3";
            button3.Size = new Size(223, 51);
            button3.TabIndex = 6;
            button3.Text = "Принять решение";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(176, 9);
            button4.Name = "button4";
            button4.Size = new Size(25, 25);
            button4.TabIndex = 7;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 488);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 27);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(43, 451);
            label3.Name = "label3";
            label3.Size = new Size(205, 28);
            label3.TabIndex = 9;
            label3.Text = "Принятое решение:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.2F);
            radioButton1.Location = new Point(477, 45);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(224, 27);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Минимаксный критерий";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.2F);
            radioButton2.Location = new Point(477, 76);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(294, 27);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Максиминный критерий (Вальда)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 10.2F);
            radioButton3.Location = new Point(477, 107);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(394, 27);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Критерий минимаксного сожаления Сэвиджа";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 10.2F);
            radioButton4.Location = new Point(477, 136);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(210, 27);
            radioButton4.TabIndex = 13;
            radioButton4.TabStop = true;
            radioButton4.Text = "Критерий максимакса ";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 10.2F);
            radioButton5.Location = new Point(477, 165);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(460, 27);
            radioButton5.TabIndex = 14;
            radioButton5.TabStop = true;
            radioButton5.Text = "Критерий недостаточного основания Байеса-Лапласа";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Segoe UI", 10.2F);
            radioButton6.Location = new Point(477, 196);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(372, 27);
            radioButton6.TabIndex = 15;
            radioButton6.TabStop = true;
            radioButton6.Text = "Критерий пессимизма-оптимизма Гурвица";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("Segoe UI", 10.2F);
            radioButton8.Location = new Point(477, 227);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(198, 27);
            radioButton8.TabIndex = 17;
            radioButton8.TabStop = true;
            radioButton8.Text = "Критерий Гермейера";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Font = new Font("Segoe UI", 10.2F);
            radioButton9.Location = new Point(477, 256);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(226, 27);
            radioButton9.TabIndex = 18;
            radioButton9.TabStop = true;
            radioButton9.Text = "Критерий произведений";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(5, 443);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 5);
            panel1.TabIndex = 19;
            // 
            // button5
            // 
            button5.Location = new Point(215, 37);
            button5.Name = "button5";
            button5.Size = new Size(175, 32);
            button5.TabIndex = 20;
            button5.Text = "Добавить строку";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(27, 37);
            button6.Name = "button6";
            button6.Size = new Size(175, 32);
            button6.TabIndex = 21;
            button6.Text = "Добавить столбец";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(850, 201);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 22;
            label4.Text = "λ = ";
            label4.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(888, 195);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 27);
            textBox2.TabIndex = 23;
            textBox2.Visible = false;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 315);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(923, 52);
            dataGridView2.TabIndex = 24;
            dataGridView2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 588);
            Controls.Add(dataGridView2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(radioButton9);
            Controls.Add(radioButton8);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Чёткий выбор";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private Panel panel1;
        private Button button5;
        private Button button6;
        private Label label4;
        private TextBox textBox2;
        private DataGridView dataGridView2;
    }
}
