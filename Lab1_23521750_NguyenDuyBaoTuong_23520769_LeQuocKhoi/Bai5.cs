using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_23521750_NguyenDuyBaoTuong_23520769_LeQuocKhoi
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Xuat_Click(object sender, EventArgs e)
        {
            string input = textBox_DanhSachDiem.Text.Trim();
            string[] stringarray = input.Split(' ');
            double[] doublearray = new double[stringarray.Length];
            double DiemTB;
            double DiemMax=0;
            double DiemMin=Double.MaxValue;
            int SoMonDau=0;
            int SoMonRot=0;
            string XepLoaiHocLuc="";
            for (int i = 0; i < stringarray.Length; i++)
            {
                if (Double.TryParse(stringarray[i], out double result)&&0<=result&&result<=10)
                {
                    doublearray[i] = result;
                }
                else
                {
                    MessageBox.Show("Dữ liệu không đúng định dạng.Vui lòng nhập lại!");
                    break;
                }
            }
            int index = 0;
            foreach (int kq in doublearray)
            {
                index++;
                if (index % 5 == 0)
                {
                    richTextBox_KetQua.AppendText("Môn học" + index + ":" + kq.ToString("F1") + '\n');
                }
                else
                {
                    richTextBox_KetQua.AppendText("Môn học" + index + ":" + kq.ToString("F1") + '\t');
                }
            }
            double Sum = 0;
            for (int i = 0; i < doublearray.Length; i++)
            {
                Sum += doublearray[i];
            }
            DiemTB = Sum / doublearray.Length;
            label_DiemTrungBinh.Text += DiemTB.ToString("F2");
            for(int i = 0;i < doublearray.Length;i++)
            {
                if (DiemMax < doublearray[i])
                {
                    DiemMax = doublearray[i];
                }    
            }    
            for(int i = 0; i<doublearray.Length;i++)
            {
                if(DiemMin > doublearray[i])
                {
                    DiemMin = doublearray[i];
                }    
            }
            label_MonCoDiemCaoNhat.Text += DiemMax.ToString("F2");
            label_MonCoDiemThapNhat.Text += DiemMin.ToString("F2");
            for(int i = 0;i<doublearray.Length ; i++)
            {
                if (doublearray[i]>=5)
                {
                    SoMonDau++;
                }    
                else
                {
                    SoMonRot++;
                }
            }
            label_SoMonDau.Text += SoMonDau.ToString();
            label_SoMonKhongDau.Text += SoMonRot.ToString();
            if (DiemTB >= 8 && DiemMin >= 6.5)
            {
                XepLoaiHocLuc = "Giỏi";
            }
            else if (DiemTB >= 6.5 && DiemMin >= 5)
            {
                XepLoaiHocLuc = "Khá";
            }
            else if(DiemTB>=5&&DiemMin>=3.5)
            {
                XepLoaiHocLuc = "Trung Bình";
            }    
            else if(DiemTB>=3.5&&DiemMin>=2)
            {
                XepLoaiHocLuc = "Yếu";
            }    
            else
            {
                XepLoaiHocLuc = "Kém";
            }
            
            label_XepLoaiHocLuc.Text += XepLoaiHocLuc;
        }
    }
}
