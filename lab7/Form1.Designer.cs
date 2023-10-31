namespace lab7
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button7 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Data";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 143);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(152, 23);
            comboBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(220, 46);
            button1.Name = "button1";
            button1.Size = new Size(281, 35);
            button1.TabIndex = 3;
            button1.Text = "Adding Data Method 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 87);
            button2.Name = "button2";
            button2.Size = new Size(281, 35);
            button2.TabIndex = 4;
            button2.Text = "Adding Data Method 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(220, 131);
            button3.Name = "button3";
            button3.Size = new Size(281, 35);
            button3.TabIndex = 5;
            button3.Text = "Adding Data Method 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(220, 172);
            button4.Name = "button4";
            button4.Size = new Size(281, 35);
            button4.TabIndex = 6;
            button4.Text = "Clear the list";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(220, 213);
            button5.Name = "button5";
            button5.Size = new Size(281, 35);
            button5.TabIndex = 7;
            button5.Text = "Getting the selected value";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(220, 254);
            button6.Name = "button6";
            button6.Size = new Size(281, 35);
            button6.TabIndex = 8;
            button6.Text = "Getting the index of the selected value";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(220, 295);
            button8.Name = "button8";
            button8.Size = new Size(281, 35);
            button8.TabIndex = 9;
            button8.Text = "removing the selected row from the list";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(220, 336);
            button7.Name = "button7";
            button7.Size = new Size(281, 35);
            button7.TabIndex = 10;
            button7.Text = "Delete a specific value";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Location = new Point(220, 377);
            button9.Name = "button9";
            button9.Size = new Size(281, 35);
            button9.TabIndex = 11;
            button9.Text = "Removing a value by index";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 450);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button7;
        private Button button9;
    }
}