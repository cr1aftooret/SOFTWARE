namespace _105_1
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
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            number = new TextBox();
            baseNumber = new TextBox();
            result = new TextBox();
            converte = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 0;
            label1.Text = "輸入一個十進位數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label2.Location = new Point(36, 147);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "輸入基底";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label3.Location = new Point(294, 147);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "轉換結果";
            // 
            // number
            // 
            number.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            number.Location = new Point(36, 78);
            number.Name = "number";
            number.Size = new Size(184, 28);
            number.TabIndex = 3;
            // 
            // baseNumber
            // 
            baseNumber.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            baseNumber.Location = new Point(36, 202);
            baseNumber.Name = "baseNumber";
            baseNumber.Size = new Size(184, 28);
            baseNumber.TabIndex = 4;
            // 
            // result
            // 
            result.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            result.Location = new Point(294, 202);
            result.Name = "result";
            result.Size = new Size(184, 28);
            result.TabIndex = 5;
            // 
            // converte
            // 
            converte.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            converte.Location = new Point(69, 311);
            converte.Name = "converte";
            converte.Size = new Size(107, 41);
            converte.TabIndex = 6;
            converte.Text = "轉換";
            converte.UseVisualStyleBackColor = true;
            converte.Click += converte_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            clear.Location = new Point(313, 311);
            clear.Name = "clear";
            clear.Size = new Size(107, 41);
            clear.TabIndex = 7;
            clear.Text = "清除";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 413);
            Controls.Add(clear);
            Controls.Add(converte);
            Controls.Add(result);
            Controls.Add(baseNumber);
            Controls.Add(number);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "數字系統轉換";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox number;
        private TextBox baseNumber;
        private TextBox result;
        private Button converte;
        private Button clear;
    }
}
