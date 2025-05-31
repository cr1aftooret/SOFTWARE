namespace _113_1
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
            input = new TextBox();
            output = new TextBox();
            clac = new Button();
            clear = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label1.Location = new Point(44, 55);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "輸入連分數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label2.Location = new Point(44, 266);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "輸出分數=";
            // 
            // input
            // 
            input.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            input.Location = new Point(207, 76);
            input.Name = "input";
            input.Size = new Size(159, 28);
            input.TabIndex = 2;
            // 
            // output
            // 
            output.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            output.Location = new Point(148, 258);
            output.Name = "output";
            output.Size = new Size(127, 28);
            output.TabIndex = 3;
            // 
            // clac
            // 
            clac.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            clac.Location = new Point(67, 164);
            clac.Name = "clac";
            clac.Size = new Size(100, 36);
            clac.TabIndex = 4;
            clac.Text = "計算";
            clac.UseVisualStyleBackColor = true;
            clac.Click += clac_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            clear.Location = new Point(207, 164);
            clear.Name = "clear";
            clear.Size = new Size(100, 36);
            clear.TabIndex = 5;
            clear.Text = "清除";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label3.Location = new Point(44, 84);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 6;
            label3.Text = "[a0,a1,a2,…,an]=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 353);
            Controls.Add(label3);
            Controls.Add(clear);
            Controls.Add(clac);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "連分數計算機";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox input;
        private TextBox output;
        private Button clac;
        private Button clear;
        private Label label3;
    }
}
