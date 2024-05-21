namespace GUICalculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonAdd = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            button10 = new Button();
            buttonEquals = new Button();
            buttonDivide = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 153);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(99, 153);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(155, 153);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 10;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(43, 209);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 11;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(99, 209);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 12;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(155, 209);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 13;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(43, 265);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 14;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(99, 265);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 15;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(155, 265);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 16;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(238, 153);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(50, 50);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(238, 209);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(50, 50);
            buttonMinus.TabIndex = 19;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(238, 265);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(50, 50);
            buttonMultiply.TabIndex = 20;
            buttonMultiply.Text = "x";
            buttonMultiply.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(43, 321);
            button10.Name = "button10";
            button10.Size = new Size(162, 50);
            button10.TabIndex = 22;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(294, 153);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(50, 218);
            buttonEquals.TabIndex = 23;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(238, 321);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(50, 50);
            buttonDivide.TabIndex = 24;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(301, 112);
            textBox1.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(393, 391);
            Controls.Add(textBox1);
            Controls.Add(buttonDivide);
            Controls.Add(buttonEquals);
            Controls.Add(button10);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonAdd);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(409, 430);
            MinimumSize = new Size(409, 430);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // number buttons
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;

        // calculation buttons
        private Button buttonAdd;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonEquals;
        private Button buttonDivide;

        // result display
        private TextBox textBox1;




    }
}
