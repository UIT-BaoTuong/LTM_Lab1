namespace Lab1_23521750_NguyenDuyBaoTuong_23520769_LeQuocKhoi
{
    partial class Bai4
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
            this.groupBox_NhapThongTin = new System.Windows.Forms.GroupBox();
            this.button_ThucHien = new System.Windows.Forms.Button();
            this.comboBox_Sang = new System.Windows.Forms.ComboBox();
            this.comboBox_Chon = new System.Windows.Forms.ComboBox();
            this.textBox_NhapMotSo = new System.Windows.Forms.TextBox();
            this.label_Sang = new System.Windows.Forms.Label();
            this.label_Chon = new System.Windows.Forms.Label();
            this.label_NhapMotSo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_KetQua = new System.Windows.Forms.Label();
            this.textBox_KetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_NhapThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_NhapThongTin
            // 
            this.groupBox_NhapThongTin.Controls.Add(this.button_ThucHien);
            this.groupBox_NhapThongTin.Controls.Add(this.comboBox_Sang);
            this.groupBox_NhapThongTin.Controls.Add(this.comboBox_Chon);
            this.groupBox_NhapThongTin.Controls.Add(this.textBox_NhapMotSo);
            this.groupBox_NhapThongTin.Controls.Add(this.label_Sang);
            this.groupBox_NhapThongTin.Controls.Add(this.label_Chon);
            this.groupBox_NhapThongTin.Controls.Add(this.label_NhapMotSo);
            this.groupBox_NhapThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NhapThongTin.Location = new System.Drawing.Point(62, 48);
            this.groupBox_NhapThongTin.Name = "groupBox_NhapThongTin";
            this.groupBox_NhapThongTin.Size = new System.Drawing.Size(667, 275);
            this.groupBox_NhapThongTin.TabIndex = 0;
            this.groupBox_NhapThongTin.TabStop = false;
            this.groupBox_NhapThongTin.Text = "Nhập Thông Tin";
            // 
            // button_ThucHien
            // 
            this.button_ThucHien.Location = new System.Drawing.Point(170, 207);
            this.button_ThucHien.Name = "button_ThucHien";
            this.button_ThucHien.Size = new System.Drawing.Size(462, 53);
            this.button_ThucHien.TabIndex = 3;
            this.button_ThucHien.Text = "Thực Hiện";
            this.button_ThucHien.UseVisualStyleBackColor = true;
            this.button_ThucHien.Click += new System.EventHandler(this.button1_ThucHien);
            // 
            // comboBox_Sang
            // 
            this.comboBox_Sang.FormattingEnabled = true;
            this.comboBox_Sang.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexadecimal"});
            this.comboBox_Sang.Location = new System.Drawing.Point(446, 156);
            this.comboBox_Sang.Name = "comboBox_Sang";
            this.comboBox_Sang.Size = new System.Drawing.Size(186, 28);
            this.comboBox_Sang.TabIndex = 2;
            // 
            // comboBox_Chon
            // 
            this.comboBox_Chon.FormattingEnabled = true;
            this.comboBox_Chon.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexadecimal"});
            this.comboBox_Chon.Location = new System.Drawing.Point(169, 156);
            this.comboBox_Chon.Name = "comboBox_Chon";
            this.comboBox_Chon.Size = new System.Drawing.Size(193, 28);
            this.comboBox_Chon.TabIndex = 2;
            // 
            // textBox_NhapMotSo
            // 
            this.textBox_NhapMotSo.Location = new System.Drawing.Point(169, 84);
            this.textBox_NhapMotSo.Name = "textBox_NhapMotSo";
            this.textBox_NhapMotSo.Size = new System.Drawing.Size(463, 27);
            this.textBox_NhapMotSo.TabIndex = 1;
            // 
            // label_Sang
            // 
            this.label_Sang.AutoSize = true;
            this.label_Sang.Location = new System.Drawing.Point(389, 159);
            this.label_Sang.Name = "label_Sang";
            this.label_Sang.Size = new System.Drawing.Size(51, 20);
            this.label_Sang.TabIndex = 0;
            this.label_Sang.Text = "Sang";
            // 
            // label_Chon
            // 
            this.label_Chon.AutoSize = true;
            this.label_Chon.Location = new System.Drawing.Point(105, 159);
            this.label_Chon.Name = "label_Chon";
            this.label_Chon.Size = new System.Drawing.Size(58, 20);
            this.label_Chon.TabIndex = 0;
            this.label_Chon.Text = "Chọn:";
            // 
            // label_NhapMotSo
            // 
            this.label_NhapMotSo.AutoSize = true;
            this.label_NhapMotSo.Location = new System.Drawing.Point(42, 87);
            this.label_NhapMotSo.Name = "label_NhapMotSo";
            this.label_NhapMotSo.Size = new System.Drawing.Size(121, 20);
            this.label_NhapMotSo.TabIndex = 0;
            this.label_NhapMotSo.Text = "Nhập một số:";
            // 
            // label_KetQua
            // 
            this.label_KetQua.AutoSize = true;
            this.label_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KetQua.Location = new System.Drawing.Point(136, 346);
            this.label_KetQua.Name = "label_KetQua";
            this.label_KetQua.Size = new System.Drawing.Size(89, 22);
            this.label_KetQua.TabIndex = 0;
            this.label_KetQua.Text = "Kết Quả:";
            // 
            // textBox_KetQua
            // 
            this.textBox_KetQua.Location = new System.Drawing.Point(232, 345);
            this.textBox_KetQua.Name = "textBox_KetQua";
            this.textBox_KetQua.ReadOnly = true;
            this.textBox_KetQua.Size = new System.Drawing.Size(463, 22);
            this.textBox_KetQua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHUYỂN ĐỔI CƠ SỐ GIỮA BIN,DEC,HEX";
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_NhapThongTin);
            this.Controls.Add(this.label_KetQua);
            this.Controls.Add(this.textBox_KetQua);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.groupBox_NhapThongTin.ResumeLayout(false);
            this.groupBox_NhapThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_NhapThongTin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox_Chon;
        private System.Windows.Forms.TextBox textBox_NhapMotSo;
        private System.Windows.Forms.Label label_Chon;
        private System.Windows.Forms.Label label_NhapMotSo;
        private System.Windows.Forms.ComboBox comboBox_Sang;
        private System.Windows.Forms.Label label_Sang;
        private System.Windows.Forms.Button button_ThucHien;
        private System.Windows.Forms.Label label_KetQua;
        private System.Windows.Forms.TextBox textBox_KetQua;
        private System.Windows.Forms.Label label1;
    }
}