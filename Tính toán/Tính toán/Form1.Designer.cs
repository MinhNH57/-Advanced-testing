namespace Tính_toán
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
            label3 = new Label();
            txt_so1 = new TextBox();
            txt_so2 = new TextBox();
            btn_Tong = new Button();
            btn_tich = new Button();
            label4 = new Label();
            txt_giaiThua = new TextBox();
            label5 = new Label();
            txt_ketquagiathua = new TextBox();
            txt_ketQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 25);
            label1.Name = "label1";
            label1.Size = new Size(398, 46);
            label1.TabIndex = 0;
            label1.Text = "Chương trình tính toán ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 113);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 1;
            label2.Text = "A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(423, 113);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 1;
            label3.Text = "B:";
            // 
            // txt_so1
            // 
            txt_so1.Location = new Point(246, 106);
            txt_so1.Name = "txt_so1";
            txt_so1.Size = new Size(125, 27);
            txt_so1.TabIndex = 2;
            // 
            // txt_so2
            // 
            txt_so2.Location = new Point(450, 106);
            txt_so2.Name = "txt_so2";
            txt_so2.Size = new Size(125, 27);
            txt_so2.TabIndex = 2;
            // 
            // btn_Tong
            // 
            btn_Tong.Location = new Point(277, 161);
            btn_Tong.Name = "btn_Tong";
            btn_Tong.Size = new Size(94, 29);
            btn_Tong.TabIndex = 3;
            btn_Tong.Text = "Tổng";
            btn_Tong.UseVisualStyleBackColor = true;
            btn_Tong.Click += btn_Tong_Click;
            // 
            // btn_tich
            // 
            btn_tich.Location = new Point(423, 161);
            btn_tich.Name = "btn_tich";
            btn_tich.Size = new Size(94, 29);
            btn_tich.TabIndex = 3;
            btn_tich.Text = "Tích";
            btn_tich.UseVisualStyleBackColor = true;
            btn_tich.Click += btn_tich_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 293);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 4;
            label4.Text = "Giai thừa của ";
            // 
            // txt_giaiThua
            // 
            txt_giaiThua.Location = new Point(118, 286);
            txt_giaiThua.Name = "txt_giaiThua";
            txt_giaiThua.Size = new Size(73, 27);
            txt_giaiThua.TabIndex = 5;
            txt_giaiThua.TextChanged += txt_giaiThua_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 293);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 4;
            label5.Text = "là:";
            // 
            // txt_ketquagiathua
            // 
            txt_ketquagiathua.Enabled = false;
            txt_ketquagiathua.Location = new Point(227, 286);
            txt_ketquagiathua.Name = "txt_ketquagiathua";
            txt_ketquagiathua.Size = new Size(73, 27);
            txt_ketquagiathua.TabIndex = 5;
            // 
            // txt_ketQua
            // 
            txt_ketQua.Enabled = false;
            txt_ketQua.Location = new Point(227, 196);
            txt_ketQua.Multiline = true;
            txt_ketQua.Name = "txt_ketQua";
            txt_ketQua.Size = new Size(348, 84);
            txt_ketQua.TabIndex = 6;
            txt_ketQua.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 332);
            Controls.Add(txt_ketQua);
            Controls.Add(txt_ketquagiathua);
            Controls.Add(txt_giaiThua);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_tich);
            Controls.Add(btn_Tong);
            Controls.Add(txt_so2);
            Controls.Add(txt_so1);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox txt_so1;
        private TextBox txt_so2;
        private Button btn_Tong;
        private Button btn_tich;
        private Label label4;
        private TextBox txt_giaiThua;
        private Label label5;
        private TextBox txt_ketquagiathua;
        private TextBox txt_ketQua;
    }
}
