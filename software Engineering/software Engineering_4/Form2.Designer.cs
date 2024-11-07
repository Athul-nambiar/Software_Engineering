namespace software_Engineering_4
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
            TestingGP4 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TestingGP4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(315, 194);
            button1.Name = "button1";
            button1.Size = new Size(146, 49);
            button1.TabIndex = 0;
            button1.Text = "form 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TestingGP4
            // 
            TestingGP4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TestingGP4.Location = new Point(298, 41);
            TestingGP4.Name = "TestingGP4";
            TestingGP4.Size = new Size(186, 124);
            TestingGP4.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TestingGP4);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Test_gp4";
            ((System.ComponentModel.ISupportInitialize)TestingGP4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView TestingGP4;
    }
}