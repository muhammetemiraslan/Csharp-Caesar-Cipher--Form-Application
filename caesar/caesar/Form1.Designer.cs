namespace caesar
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			label3 = new Label();
			textBox3 = new TextBox();
			button2 = new Button();
			button3 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(74, 49);
			label1.Name = "label1";
			label1.Size = new Size(41, 20);
			label1.TabIndex = 0;
			label1.Text = "text :";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(74, 171);
			label2.Name = "label2";
			label2.Size = new Size(111, 20);
			label2.TabIndex = 1;
			label2.Text = "encrypted text :";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(242, 26);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(425, 71);
			textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(242, 138);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(425, 81);
			textBox2.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(242, 103);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 4;
			button1.Text = "encrypt";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(74, 293);
			label3.Name = "label3";
			label3.Size = new Size(116, 20);
			label3.TabIndex = 5;
			label3.Text = "Decrypted Text :";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(242, 261);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(425, 74);
			textBox3.TabIndex = 6;
			// 
			// button2
			// 
			button2.Location = new Point(242, 225);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 7;
			button2.Text = "decrypte";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(242, 345);
			button3.Name = "button3";
			button3.Size = new Size(425, 29);
			button3.TabIndex = 8;
			button3.Text = "clean";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(726, 450);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
    }
}