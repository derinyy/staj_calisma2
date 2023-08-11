namespace WinFormsApp22
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
            panel1 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            groupBox4 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 54);
            panel1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(597, 16);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(132, 26);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "credit", "cash" });
            comboBox1.Location = new Point(156, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 26);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 19);
            label2.Name = "label2";
            label2.Size = new Size(133, 18);
            label2.TabIndex = 2;
            label2.Text = "reservation date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 0;
            label1.Text = "payment method:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 287);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENU";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 206);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(80, 26);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(80, 26);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(80, 26);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(80, 26);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(80, 26);
            textBox1.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 214);
            label8.Name = "label8";
            label8.Size = new Size(46, 18);
            label8.TabIndex = 4;
            label8.Text = "bowl:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 174);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 3;
            label7.Text = "waffle:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 44);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 0;
            label4.Text = "milkshake:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 85);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 1;
            label5.Text = "americano:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 133);
            label6.Name = "label6";
            label6.Size = new Size(61, 18);
            label6.TabIndex = 2;
            label6.Text = "mocha:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(234, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(156, 287);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "PRICE LIST";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 206);
            label13.Name = "label13";
            label13.Size = new Size(82, 18);
            label13.TabIndex = 7;
            label13.Text = "bowl $$10";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 166);
            label12.Name = "label12";
            label12.Size = new Size(92, 18);
            label12.TabIndex = 6;
            label12.Text = "waffle $$15";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 125);
            label11.Name = "label11";
            label11.Size = new Size(88, 18);
            label11.TabIndex = 5;
            label11.Text = "mocha $$5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 85);
            label10.Name = "label10";
            label10.Size = new Size(116, 18);
            label10.TabIndex = 4;
            label10.Text = "americano $$4";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 44);
            label9.Name = "label9";
            label9.Size = new Size(113, 18);
            label9.TabIndex = 3;
            label9.Text = "milkshake $$2";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(128, 255, 128);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(400, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(363, 133);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "ORDER NOTE";
            // 
            // button2
            // 
            button2.Location = new Point(126, 85);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 2;
            button2.Text = "send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(26, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(321, 50);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(128, 255, 128);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(label3);
            groupBox4.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(400, 236);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(363, 133);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "CASH BOX";
            // 
            // button1
            // 
            button1.Location = new Point(126, 75);
            button1.Name = "button1";
            button1.Size = new Size(108, 27);
            button1.TabIndex = 1;
            button1.Text = "payment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 42);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 0;
            label3.Text = "TOTAL $$";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 394);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private GroupBox groupBox3;
        private Button button2;
        private RichTextBox richTextBox1;
        private GroupBox groupBox4;
        private Button button1;
        private Label label3;
    }
}