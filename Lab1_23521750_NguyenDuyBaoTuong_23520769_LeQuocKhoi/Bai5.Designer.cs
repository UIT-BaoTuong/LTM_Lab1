namespace Lab1_23521750_NguyenDuyBaoTuong_23520769_LeQuocKhoi
{
    partial class Bai5
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_DanhSachDiem = new System.Windows.Forms.Label();
            this.textBox_DanhSachDiem = new System.Windows.Forms.TextBox();
            this.label_DiemTrungBinh = new System.Windows.Forms.Label();
            this.label_MonCoDiemCaoNhat = new System.Windows.Forms.Label();
            this.label_SoMonDau = new System.Windows.Forms.Label();
            this.label_XepLoaiHocLuc = new System.Windows.Forms.Label();
            this.label_MonCoDiemThapNhat = new System.Windows.Forms.Label();
            this.label_SoMonKhongDau = new System.Windows.Forms.Label();
            this.button_Xuat = new System.Windows.Forms.Button();
            this.richTextBox_KetQua = new System.Windows.Forms.RichTextBox();
            this.label_KetQua = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(239, 24);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(327, 25);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "PHẦN MỀM QUẢN LÝ ĐIỂM";
            // 
            // label_DanhSachDiem
            // 
            this.label_DanhSachDiem.AutoSize = true;
            this.label_DanhSachDiem.Location = new System.Drawing.Point(37, 87);
            this.label_DanhSachDiem.Name = "label_DanhSachDiem";
            this.label_DanhSachDiem.Size = new System.Drawing.Size(104, 16);
            this.label_DanhSachDiem.TabIndex = 1;
            this.label_DanhSachDiem.Text = "Danh sách điểm";
            // 
            // textBox_DanhSachDiem
            // 
            this.textBox_DanhSachDiem.Location = new System.Drawing.Point(147, 84);
            this.textBox_DanhSachDiem.Name = "textBox_DanhSachDiem";
            this.textBox_DanhSachDiem.Size = new System.Drawing.Size(535, 22);
            this.textBox_DanhSachDiem.TabIndex = 2;
            // 
            // label_DiemTrungBinh
            // 
            this.label_DiemTrungBinh.AutoSize = true;
            this.label_DiemTrungBinh.Location = new System.Drawing.Point(47, 341);
            this.label_DiemTrungBinh.Name = "label_DiemTrungBinh";
            this.label_DiemTrungBinh.Size = new System.Drawing.Size(101, 16);
            this.label_DiemTrungBinh.TabIndex = 4;
            this.label_DiemTrungBinh.Text = "Điểm trung bình:";
            // 
            // label_MonCoDiemCaoNhat
            // 
            this.label_MonCoDiemCaoNhat.AutoSize = true;
            this.label_MonCoDiemCaoNhat.Location = new System.Drawing.Point(47, 377);
            this.label_MonCoDiemCaoNhat.Name = "label_MonCoDiemCaoNhat";
            this.label_MonCoDiemCaoNhat.Size = new System.Drawing.Size(141, 16);
            this.label_MonCoDiemCaoNhat.TabIndex = 4;
            this.label_MonCoDiemCaoNhat.Text = "Môn có điểm cao nhất:";
            // 
            // label_SoMonDau
            // 
            this.label_SoMonDau.AutoSize = true;
            this.label_SoMonDau.Location = new System.Drawing.Point(47, 412);
            this.label_SoMonDau.Name = "label_SoMonDau";
            this.label_SoMonDau.Size = new System.Drawing.Size(82, 16);
            this.label_SoMonDau.TabIndex = 4;
            this.label_SoMonDau.Text = "Số môn đậu:";
            // 
            // label_XepLoaiHocLuc
            // 
            this.label_XepLoaiHocLuc.AutoSize = true;
            this.label_XepLoaiHocLuc.Location = new System.Drawing.Point(422, 341);
            this.label_XepLoaiHocLuc.Name = "label_XepLoaiHocLuc";
            this.label_XepLoaiHocLuc.Size = new System.Drawing.Size(104, 16);
            this.label_XepLoaiHocLuc.TabIndex = 4;
            this.label_XepLoaiHocLuc.Text = "Xếp loại học lực:";
            // 
            // label_MonCoDiemThapNhat
            // 
            this.label_MonCoDiemThapNhat.AutoSize = true;
            this.label_MonCoDiemThapNhat.Location = new System.Drawing.Point(422, 377);
            this.label_MonCoDiemThapNhat.Name = "label_MonCoDiemThapNhat";
            this.label_MonCoDiemThapNhat.Size = new System.Drawing.Size(144, 16);
            this.label_MonCoDiemThapNhat.TabIndex = 4;
            this.label_MonCoDiemThapNhat.Text = "Môn có điểm thấp nhất:";
            // 
            // label_SoMonKhongDau
            // 
            this.label_SoMonKhongDau.AutoSize = true;
            this.label_SoMonKhongDau.Location = new System.Drawing.Point(422, 412);
            this.label_SoMonKhongDau.Name = "label_SoMonKhongDau";
            this.label_SoMonKhongDau.Size = new System.Drawing.Size(122, 16);
            this.label_SoMonKhongDau.TabIndex = 4;
            this.label_SoMonKhongDau.Text = "Số môn không đậu:";
            // 
            // button_Xuat
            // 
            this.button_Xuat.Location = new System.Drawing.Point(688, 84);
            this.button_Xuat.Name = "button_Xuat";
            this.button_Xuat.Size = new System.Drawing.Size(100, 52);
            this.button_Xuat.TabIndex = 5;
            this.button_Xuat.Text = "Xuất";
            this.button_Xuat.UseVisualStyleBackColor = true;
            this.button_Xuat.Click += new System.EventHandler(this.button_Xuat_Click);
            // 
            // richTextBox_KetQua
            // 
            this.richTextBox_KetQua.Location = new System.Drawing.Point(41, 150);
            this.richTextBox_KetQua.Name = "richTextBox_KetQua";
            this.richTextBox_KetQua.ReadOnly = true;
            this.richTextBox_KetQua.Size = new System.Drawing.Size(641, 171);
            this.richTextBox_KetQua.TabIndex = 6;
            this.richTextBox_KetQua.Text = "";
            // 
            // label_KetQua
            // 
            this.label_KetQua.AutoSize = true;
            this.label_KetQua.Location = new System.Drawing.Point(37, 131);
            this.label_KetQua.Name = "label_KetQua";
            this.label_KetQua.Size = new System.Drawing.Size(176, 16);
            this.label_KetQua.TabIndex = 1;
            this.label_KetQua.Text = "Danh sách môn học và điểm";
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_KetQua);
            this.Controls.Add(this.button_Xuat);
            this.Controls.Add(this.label_SoMonKhongDau);
            this.Controls.Add(this.label_SoMonDau);
            this.Controls.Add(this.label_MonCoDiemThapNhat);
            this.Controls.Add(this.label_XepLoaiHocLuc);
            this.Controls.Add(this.label_MonCoDiemCaoNhat);
            this.Controls.Add(this.label_DiemTrungBinh);
            this.Controls.Add(this.textBox_DanhSachDiem);
            this.Controls.Add(this.label_KetQua);
            this.Controls.Add(this.label_DanhSachDiem);
            this.Controls.Add(this.label_Title);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_DanhSachDiem;
        private System.Windows.Forms.TextBox textBox_DanhSachDiem;
        private System.Windows.Forms.Label label_DiemTrungBinh;
        private System.Windows.Forms.Label label_MonCoDiemCaoNhat;
        private System.Windows.Forms.Label label_SoMonDau;
        private System.Windows.Forms.Label label_XepLoaiHocLuc;
        private System.Windows.Forms.Label label_MonCoDiemThapNhat;
        private System.Windows.Forms.Label label_SoMonKhongDau;
        private System.Windows.Forms.Button button_Xuat;
        private System.Windows.Forms.RichTextBox richTextBox_KetQua;
        private System.Windows.Forms.Label label_KetQua;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}