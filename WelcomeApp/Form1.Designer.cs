namespace WelcomeApp
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
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 41);
            label1.Name = "label1";
            label1.Size = new Size(185, 44);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 132);
            label2.Name = "label2";
            label2.Size = new Size(121, 27);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(154, 177);
            label3.Name = "label3";
            label3.Size = new Size(121, 27);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Snap ITC", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(434, 225);
            button1.Name = "button1";
            button1.Size = new Size(117, 45);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 325);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Welcome Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
    }
}
