namespace software_Engineering_4
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
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            monthCalendar1 = new MonthCalendar();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button5 = new Button();
            button6 = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(-6, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 93);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(159, 66);
            button3.Name = "button3";
            button3.Size = new Size(61, 22);
            button3.TabIndex = 3;
            button3.Text = "sign out";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 66);
            button2.Name = "button2";
            button2.Size = new Size(85, 22);
            button2.TabIndex = 2;
            button2.Text = "Community";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 66);
            button1.Name = "button1";
            button1.Size = new Size(49, 22);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 23);
            label1.Name = "label1";
            label1.Size = new Size(180, 36);
            label1.TabIndex = 0;
            label1.Text = "Event Tracker";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Firebrick;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(monthCalendar1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(554, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 354);
            panel3.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(62, 290);
            button4.Name = "button4";
            button4.Size = new Size(129, 38);
            button4.TabIndex = 4;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(8, 116);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(8, 10);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Events";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(14, 248);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 3;
            label3.Text = "Request an Event";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 355);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(15, 290);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 6;
            label4.Text = "Name of the Event";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(15, 337);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 7;
            label5.Text = "Date and Time";
            label5.Click += label5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(280, 308);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(142, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(280, 290);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 9;
            label6.Text = "Estimated Participants";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(8, 41);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 10;
            label7.Text = "Name ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(8, 92);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 11;
            label8.Text = "Date ";
            label8.Click += label8_Click;
            // 
            // button5
            // 
            button5.Location = new Point(173, 400);
            button5.Name = "button5";
            button5.Size = new Size(129, 38);
            button5.TabIndex = 12;
            button5.Text = "Submit Request";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(664, 31);
            button6.Name = "button6";
            button6.Size = new Size(94, 38);
            button6.TabIndex = 4;
            button6.Text = "Profile";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(804, 450);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Panel panel3;
        private TextBox textBox1;
        private Label label2;
        private Button button4;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button5;
        private Button button6;
    }
}
