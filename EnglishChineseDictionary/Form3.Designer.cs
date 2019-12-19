namespace EnglishChineseDictionary
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MySQL连接信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "host:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "user:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 25);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "3306";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 25);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "root";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(228, 25);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "1999";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "导入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "数据库名称：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "表名：";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(164, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 25);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "englishchinesedictionary";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(164, 240);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(201, 25);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "words";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "单词列名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "中文释义列名：";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(164, 271);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(201, 25);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "word_key";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(164, 302);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(201, 25);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "word_mean";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 426);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(449, 473);
            this.Name = "Form3";
            this.Text = "从数据库导入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}