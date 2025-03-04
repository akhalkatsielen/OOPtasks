namespace WelcomeApp
{
    partial class Calculator
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
            outputTextBox = new TextBox();
            sevenButton = new Button();
            eigthButton = new Button();
            nineButton = new Button();
            plusButton = new Button();
            minusButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            multiButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            divisionButton = new Button();
            equalsButton = new Button();
            zeroButton = new Button();
            cleanButton = new Button();
            SuspendLayout();
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(48, 61);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(282, 27);
            outputTextBox.TabIndex = 0;
            outputTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // sevenButton
            // 
            sevenButton.Location = new Point(48, 118);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(66, 58);
            sevenButton.TabIndex = 1;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.Click += valueButton_Click;
            // 
            // eigthButton
            // 
            eigthButton.Location = new Point(120, 118);
            eigthButton.Name = "eigthButton";
            eigthButton.Size = new Size(66, 58);
            eigthButton.TabIndex = 2;
            eigthButton.Text = "8";
            eigthButton.UseVisualStyleBackColor = true;
            eigthButton.Click += valueButton_Click;
            // 
            // nineButton
            // 
            nineButton.Location = new Point(192, 118);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(66, 58);
            nineButton.TabIndex = 3;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.Click += valueButton_Click;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(264, 118);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(66, 58);
            plusButton.TabIndex = 4;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += operationButton_Click;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(264, 182);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(66, 58);
            minusButton.TabIndex = 8;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += operationButton_Click;
            // 
            // sixButton
            // 
            sixButton.Location = new Point(192, 182);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(66, 58);
            sixButton.TabIndex = 7;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.Click += valueButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.Location = new Point(120, 182);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(66, 58);
            fiveButton.TabIndex = 6;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.Click += valueButton_Click;
            // 
            // fourButton
            // 
            fourButton.Location = new Point(48, 182);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(66, 58);
            fourButton.TabIndex = 5;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.Click += valueButton_Click;
            // 
            // multiButton
            // 
            multiButton.Location = new Point(264, 246);
            multiButton.Name = "multiButton";
            multiButton.Size = new Size(66, 58);
            multiButton.TabIndex = 12;
            multiButton.Text = "*";
            multiButton.UseVisualStyleBackColor = true;
            multiButton.Click += operationButton_Click;
            // 
            // threeButton
            // 
            threeButton.Location = new Point(192, 246);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(66, 58);
            threeButton.TabIndex = 11;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.Click += valueButton_Click;
            // 
            // twoButton
            // 
            twoButton.Location = new Point(120, 246);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(66, 58);
            twoButton.TabIndex = 10;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            twoButton.Click += valueButton_Click;
            // 
            // oneButton
            // 
            oneButton.Location = new Point(48, 246);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(66, 58);
            oneButton.TabIndex = 9;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            oneButton.Click += valueButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.Location = new Point(264, 310);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(66, 58);
            divisionButton.TabIndex = 16;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = true;
            divisionButton.Click += operationButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.Location = new Point(192, 310);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(66, 58);
            equalsButton.TabIndex = 15;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = true;
            equalsButton.Click += equalsButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.Location = new Point(120, 310);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(66, 58);
            zeroButton.TabIndex = 14;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += valueButton_Click;
            // 
            // cleanButton
            // 
            cleanButton.Location = new Point(48, 310);
            cleanButton.Name = "cleanButton";
            cleanButton.Size = new Size(66, 58);
            cleanButton.TabIndex = 13;
            cleanButton.Text = "C";
            cleanButton.UseVisualStyleBackColor = true;
            cleanButton.Click += cleanCalc;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 430);
            Controls.Add(divisionButton);
            Controls.Add(equalsButton);
            Controls.Add(zeroButton);
            Controls.Add(cleanButton);
            Controls.Add(multiButton);
            Controls.Add(threeButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(minusButton);
            Controls.Add(sixButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(plusButton);
            Controls.Add(nineButton);
            Controls.Add(eigthButton);
            Controls.Add(sevenButton);
            Controls.Add(outputTextBox);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox outputTextBox;
        private Button sevenButton;
        private Button eigthButton;
        private Button nineButton;
        private Button plusButton;
        private Button minusButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button multiButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private Button divisionButton;
        private Button equalsButton;
        private Button zeroButton;
        private Button cleanButton;
    }
}