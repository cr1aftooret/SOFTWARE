namespace _108_1
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
            cocacola = new PictureBox();
            pepsi = new PictureBox();
            dietcoke = new PictureBox();
            dietpepsi = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            result = new Label();
            refund = new Button();
            deposit = new Button();
            label5 = new Label();
            balanceText = new TextBox();
            five = new RadioButton();
            ten = new RadioButton();
            fifty = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)cocacola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pepsi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dietcoke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dietpepsi).BeginInit();
            SuspendLayout();
            // 
            // cocacola
            // 
            cocacola.Image = Properties.Resources.cocacola;
            cocacola.Location = new Point(30, 33);
            cocacola.Name = "cocacola";
            cocacola.Size = new Size(82, 78);
            cocacola.SizeMode = PictureBoxSizeMode.StretchImage;
            cocacola.TabIndex = 0;
            cocacola.TabStop = false;
            cocacola.Click += cocacola_Click;
            // 
            // pepsi
            // 
            pepsi.Image = Properties.Resources.pepsic;
            pepsi.Location = new Point(30, 127);
            pepsi.Name = "pepsi";
            pepsi.Size = new Size(82, 78);
            pepsi.SizeMode = PictureBoxSizeMode.StretchImage;
            pepsi.TabIndex = 1;
            pepsi.TabStop = false;
            pepsi.Click += pepsi_Click;
            // 
            // dietcoke
            // 
            dietcoke.Image = Properties.Resources.images;
            dietcoke.Location = new Point(30, 325);
            dietcoke.Name = "dietcoke";
            dietcoke.Size = new Size(82, 78);
            dietcoke.SizeMode = PictureBoxSizeMode.StretchImage;
            dietcoke.TabIndex = 2;
            dietcoke.TabStop = false;
            dietcoke.Click += dietcoke_Click;
            // 
            // dietpepsi
            // 
            dietpepsi.Image = Properties.Resources.dietpepsi;
            dietpepsi.Location = new Point(30, 229);
            dietpepsi.Name = "dietpepsi";
            dietpepsi.Size = new Size(82, 78);
            dietpepsi.SizeMode = PictureBoxSizeMode.StretchImage;
            dietpepsi.TabIndex = 3;
            dietpepsi.TabStop = false;
            dietpepsi.Click += dietpepsi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label1.Location = new Point(146, 72);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 4;
            label1.Text = "35元";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label2.Location = new Point(146, 157);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 5;
            label2.Text = "30元";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label3.Location = new Point(146, 257);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 6;
            label3.Text = "25元";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label4.Location = new Point(146, 350);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "30元";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            result.Location = new Point(30, 488);
            result.Name = "result";
            result.Size = new Size(0, 20);
            result.TabIndex = 8;
            // 
            // refund
            // 
            refund.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            refund.Location = new Point(30, 422);
            refund.Name = "refund";
            refund.Size = new Size(196, 32);
            refund.TabIndex = 9;
            refund.Text = "退款(refund)";
            refund.UseVisualStyleBackColor = true;
            refund.Click += refund_Click;
            // 
            // deposit
            // 
            deposit.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            deposit.Location = new Point(444, 287);
            deposit.Name = "deposit";
            deposit.Size = new Size(117, 57);
            deposit.TabIndex = 10;
            deposit.Text = "投幣\n(deposit)";
            deposit.UseVisualStyleBackColor = true;
            deposit.Click += deposit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label5.Location = new Point(429, 46);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 11;
            label5.Text = "存款(balance$)";
            // 
            // balanceText
            // 
            balanceText.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            balanceText.Location = new Point(429, 93);
            balanceText.Name = "balanceText";
            balanceText.ReadOnly = true;
            balanceText.Size = new Size(226, 28);
            balanceText.TabIndex = 12;
            // 
            // five
            // 
            five.AutoSize = true;
            five.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            five.Location = new Point(444, 155);
            five.Name = "five";
            five.Size = new Size(53, 24);
            five.TabIndex = 13;
            five.TabStop = true;
            five.Text = "5元";
            five.UseVisualStyleBackColor = true;
            // 
            // ten
            // 
            ten.AutoSize = true;
            ten.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            ten.Location = new Point(444, 185);
            ten.Name = "ten";
            ten.Size = new Size(63, 24);
            ten.TabIndex = 14;
            ten.TabStop = true;
            ten.Text = "10元";
            ten.UseVisualStyleBackColor = true;
            // 
            // fifty
            // 
            fifty.AutoSize = true;
            fifty.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            fifty.Location = new Point(444, 215);
            fifty.Name = "fifty";
            fifty.Size = new Size(63, 24);
            fifty.TabIndex = 15;
            fifty.TabStop = true;
            fifty.Text = "50元";
            fifty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 562);
            Controls.Add(fifty);
            Controls.Add(ten);
            Controls.Add(five);
            Controls.Add(balanceText);
            Controls.Add(label5);
            Controls.Add(deposit);
            Controls.Add(refund);
            Controls.Add(result);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dietpepsi);
            Controls.Add(dietcoke);
            Controls.Add(pepsi);
            Controls.Add(cocacola);
            Name = "Form1";
            Text = "Vending Machine";
            ((System.ComponentModel.ISupportInitialize)cocacola).EndInit();
            ((System.ComponentModel.ISupportInitialize)pepsi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dietcoke).EndInit();
            ((System.ComponentModel.ISupportInitialize)dietpepsi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cocacola;
        private PictureBox pepsi;
        private PictureBox dietcoke;
        private PictureBox dietpepsi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label result;
        private Button refund;
        private Button deposit;
        private Label label5;
        private TextBox balanceText;
        private RadioButton five;
        private RadioButton ten;
        private RadioButton fifty;
    }
}
