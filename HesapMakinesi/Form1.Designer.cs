namespace HesapMakinesi
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
            num1Box = new TextBox();
            num2Box = new TextBox();
            button1 = new Button();
            label3 = new Label();
            resultBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "1. Sayı: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 75);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "2. Sayı: ";
            // 
            // num1Box
            // 
            num1Box.Location = new Point(85, 33);
            num1Box.Name = "num1Box";
            num1Box.Size = new Size(100, 23);
            num1Box.TabIndex = 2;
            num1Box.TextChanged += textBox1_TextChanged;
            // 
            // num2Box
            // 
            num2Box.Location = new Point(85, 72);
            num2Box.Name = "num2Box";
            num2Box.Size = new Size(100, 23);
            num2Box.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(98, 116);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Topla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 158);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Sonuç: ";
            // 
            // resultBox
            // 
            resultBox.Enabled = false;
            resultBox.Location = new Point(85, 155);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(100, 23);
            resultBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultBox);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(num2Box);
            Controls.Add(num1Box);
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
        private TextBox num1Box;
        private TextBox num2Box;
        private Button button1;
        private Label label3;
        private TextBox resultBox;
    }
}
