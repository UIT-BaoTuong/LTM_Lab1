using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab01_23520769_LeQuocKhoi;

namespace Lab1_23521750_NguyenDuyBaoTuong_23520769_LeQuocKhoi
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button_Bai4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            this.Hide();
            bai4.ShowDialog();
        }

        private void button_Bai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            this.Hide();
            bai2.ShowDialog();
        }

        private void button_Bai5_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            this.Hide();
            bai5.ShowDialog();

        }

        private void button_Bai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            this.Hide();
            bai1.ShowDialog();
        }

        private void button_Bai3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            this.Hide();
            bai3.ShowDialog();
        }
    }
}
