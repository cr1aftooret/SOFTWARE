namespace _110_2
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
            length = new Label();
            strength = new Label();
            input = new TextBox();
            len = new Button();
            judge = new Button();
            clear = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label1.Location = new Point(34, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "輸入字串";
            // 
            // length
            // 
            length.AutoSize = true;
            length.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            length.Location = new Point(178, 101);
            length.Name = "length";
            length.Size = new Size(55, 20);
            length.TabIndex = 1;
            length.Text = "label2";
            // 
            // strength
            // 
            strength.AutoSize = true;
            strength.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            strength.Location = new Point(178, 162);
            strength.Name = "strength";
            strength.Size = new Size(55, 20);
            strength.TabIndex = 2;
            strength.Text = "label3";
            // 
            // input
            // 
            input.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            input.Location = new Point(138, 36);
            input.Name = "input";
            input.Size = new Size(215, 28);
            input.TabIndex = 3;
            // 
            // len
            // 
            len.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            len.Location = new Point(34, 93);
            len.Name = "len";
            len.Size = new Size(91, 36);
            len.TabIndex = 4;
            len.Text = "分別長度";
            len.UseVisualStyleBackColor = true;
            len.Click += len_Click;
            // 
            // judge
            // 
            judge.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            judge.Location = new Point(34, 154);
            judge.Name = "judge";
            judge.Size = new Size(91, 36);
            judge.TabIndex = 5;
            judge.Text = "判斷";
            judge.UseVisualStyleBackColor = true;
            judge.Click += judge_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            clear.Location = new Point(34, 226);
            clear.Name = "clear";
            clear.Size = new Size(91, 36);
            clear.TabIndex = 7;
            clear.Text = "清除";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            exit.Location = new Point(159, 226);
            exit.Name = "exit";
            exit.Size = new Size(91, 36);
            exit.TabIndex = 6;
            exit.Text = "結束";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 370);
            Controls.Add(clear);
            Controls.Add(exit);
            Controls.Add(judge);
            Controls.Add(len);
            Controls.Add(input);
            Controls.Add(strength);
            Controls.Add(length);
            Controls.Add(label1);
            Name = "Form1";
            Text = "密碼分析";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label length;
        private Label strength;
        private TextBox input;
        private Button len;
        private Button judge;
        private Button clear;
        private Button exit;
    }
}
