namespace winform.Array
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 109);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 332);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(81, 43);
            label1.Name = "label1";
            label1.Size = new Size(174, 53);
            label1.TabIndex = 1;
            label1.Text = "กรอกข้อมูลตัวเลข";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(607, 109);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(587, 114);
            label3.Name = "label3";
            label3.Size = new Size(141, 39);
            label3.TabIndex = 4;
            label3.Text = "จำนวนสมาชิกข้อมูล";
            // 
            // label4
            // 
            label4.Location = new Point(587, 172);
            label4.Name = "label4";
            label4.Size = new Size(168, 41);
            label4.TabIndex = 5;
            label4.Text = "ผลรวม";
            // 
            // button1
            // 
            button1.Location = new Point(308, 114);
            button1.Name = "button1";
            button1.Size = new Size(152, 109);
            button1.TabIndex = 6;
            button1.Text = "ประมวนผล";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Location = new Point(587, 227);
            label5.Name = "label5";
            label5.Size = new Size(110, 37);
            label5.TabIndex = 7;
            label5.Text = "ค่าเฉลี่ย";
            // 
            // label6
            // 
            label6.Location = new Point(587, 296);
            label6.Name = "label6";
            label6.Size = new Size(110, 37);
            label6.TabIndex = 8;
            label6.Text = "ค่าต่ำสุด";
            // 
            // label7
            // 
            label7.Location = new Point(587, 349);
            label7.Name = "label7";
            label7.Size = new Size(110, 37);
            label7.TabIndex = 9;
            label7.Text = "ค่าสูงสุด";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(984, 707);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "ผลทดสอบ Array";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
