using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Lab1_23521750_NguyenDuyBaoTuong_23520769_LeQuocKhoi
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Tim_Click(object sender, EventArgs e)
        {
            double minn = 0;
            double maxn = 0;
            double num1, num2, num3;
            bool s1 = double.TryParse(textBox_SoThu1.Text.Trim(), out num1);
            bool s2 = double.TryParse(textBox_SoThu2.Text.Trim(), out num2);
            bool s3 = double.TryParse(textBox_SoThu3.Text.Trim(), out num3);
            if(s1 && s2 && s3)
            {
                minn=Math.Min(num1,Math.Min(num2,num3));
                maxn=Math.Max(num1,Math.Max(num2,num3));
                textBox_SoBeNhat.Text= minn.ToString();
                textBox_SoLonNhat.Text = maxn.ToString();
            }
            else
            {
                MessageBox.Show("Chỉ nhập số nguyên và số thập phân");
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            textBox_SoThu1.Text = String.Empty;
            textBox_SoThu2.Text = String.Empty;
            textBox_SoThu3.Text = String.Empty;
            textBox_SoBeNhat.Text = String.Empty;
            textBox_SoLonNhat.Text = String.Empty;
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
