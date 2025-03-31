namespace HesapMakinesi
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            num1Box = new TextBox();
            num2Box = new TextBox();
            label3 = new Label();
            resultBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 411);
            button1.Name = "button1";
            button1.Size = new Size(82, 27);
            button1.TabIndex = 0;
            button1.Text = "<- Toplama";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Sayı 1: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Sayı 2: ";
            // 
            // button2
            // 
            button2.Location = new Point(78, 101);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Çarp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // num1Box
            // 
            num1Box.Location = new Point(65, 20);
            num1Box.Name = "num1Box";
            num1Box.Size = new Size(100, 23);
            num1Box.TabIndex = 4;
            // 
            // num2Box
            // 
            num2Box.Location = new Point(65, 58);
            num2Box.Name = "num2Box";
            num2Box.Size = new Size(100, 23);
            num2Box.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Sonuç: ";
            // 
            // resultBox
            // 
            resultBox.Enabled = false;
            resultBox.Location = new Point(65, 143);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(100, 23);
            resultBox.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultBox);
            Controls.Add(label3);
            Controls.Add(num2Box);
            Controls.Add(num1Box);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private TextBox num1Box;
        private TextBox num2Box;
        private Label label3;
        private TextBox resultBox;
    }
}