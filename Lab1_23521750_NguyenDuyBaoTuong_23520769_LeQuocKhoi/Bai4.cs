using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_23521750_NguyenDuyBaoTuong_23520769_LeQuocKhoi
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        private void button1_ThucHien(object sender, EventArgs e)
        {
            //Kiểm soát dữ liệu đầu vào
            string input_str = textBox_NhapMotSo.Text.Trim();
            int input_int;
            //biến s dùng để kiểm tra dữ liệu đầu vào có phải là số nguyên không
            //s1 dùng để kiểm tra dữ liệu đầu vào có phải là kiểu binary không
            //s2 dùng để kiểm tra dữ liệu đầu vào có phải là kiểu decimal không
            //s3 dùng để kiểm tra dữ liệu đầu vào có phải là kiểu hexadecimal không
            bool s = int.TryParse(input_str, out input_int);
            bool s1=true, s2=true, s3 = true;
            //Đối với dữ liệu đầu vào khi chúng ta chọn kiểu binary và decimal thì phải kiểm tra nó là số nguyên trước
            if(s == true)
            {
                //kiểm tra dữ liệu đầu vào có phải kiểu binary không.Nếu không thỏa thì s1 = false.Và in ra của sổ cảnh báo
                if (comboBox_Chon.Text == "Binary")
                {
                    foreach (char ch in input_str)
                    {
                        if (ch != '0' && ch != '1')
                        {
                            s1 = false;
                            break;
                        }
                    }
                    if (s1 == false)
                    {
                        MessageBox.Show("Chỉ được nhập các chữ số 0 và 1 ");
                    }
                }
                //kiểm tra dữ liệu đầu vào có phải kiểu decimal không.Nếu không thỏa thì s2 = false.Và in ra của sổ cảnh báo
                if (comboBox_Chon.Text == "Decimal")
                {
                    foreach (char ch in input_str)
                    {
                        if ('0'<=ch&&ch<='9')
                        {
                        }
                        else
                        {
                            s2 = false;
                            break;
                        }    
                    }
                    if(s2==false)
                    {
                        MessageBox.Show("Chỉ được nhập các chữ số từ 0 đến 9");
                    }    
                }
            }
            //Nếu dữ liệu không phải là số nguyên và kiểu dữ liệu của input không phải hexadecimal thì in ra hộp thoại cảnh báo 
            else if (comboBox_Chon.Text != "Hexadecimal")
            {
                MessageBox.Show("Chỉ được nhập số nguyên");
            }
            //Nếu dữ liệu input là kiểu hexadecimal thì kiểm tra các chữ số có thuộc (0,9),(a,f)(A,F) không.Nếu không thuộc thì in ra hộp thoại cảnh báo
            if (comboBox_Chon.Text == "Hexadecimal")
            {
                foreach (char ch in input_str)
                {
                    if (('0' <= ch && ch <= '9') || (('a'<=ch&&ch<='f')||('A'<=ch&&ch<='F')))
                    {
                    }
                    else
                    {
                        s3 = false;
                        break;
                    }
                }
                if (s3 == false)
                {
                    MessageBox.Show("Chỉ được nhập các chữ số từ 0 đến F");
                }
            }
            //Nếu dữ liệu dầu vào là số nguyên và thõa kiểu binary và decimal
            if(s==true&&s1==true&&s2==true)
            {
                if(comboBox_Chon.Text == "Binary")
                {
                    //chuyển từ kiểu binary sang decimal
                    if(comboBox_Sang.Text == "Decimal")
                    {
                        int DecimalValue = Convert.ToInt32(input_str,2);// binary ->decimal
                        textBox_KetQua.Text = DecimalValue.ToString();
                    }
                    //chuyển từ binary sang hexadecimal
                    else if(comboBox_Sang.Text =="Hexadecimal")
                    {
                        int DecimalValue = Convert.ToInt32(input_str,2);//binary -> decimal
                        string HexadeciamlValue = DecimalValue.ToString("X");//decimal -> hexadecimal
                        textBox_KetQua.Text=HexadeciamlValue;
                    }
                }
                if(comboBox_Chon.Text == "Decimal")
                {
                    //chuyển từ decimal sang binary
                    if(comboBox_Sang.Text == "Binary")
                    {
                        string BinaryValue = Convert.ToString(input_int,2);
                        textBox_KetQua.Text = BinaryValue;
                    }
                    //chuyển từ decimal sang hexadecimal
                    else if(comboBox_Sang.Text =="Hexadecimal")
                    {
                        string HexadecimalValue = input_int.ToString("X");
                        textBox_KetQua.Text = HexadecimalValue;
                    }
                }
            }
            //Khi dữ liệu không phải là số nguyên nhưng thõa kiểu hexadecimal
            else if(s3)
            {
                if (comboBox_Chon.Text == "Hexadecimal")
                {
                    //Chuyển từ dạng hexadecimal sang binary
                    if (comboBox_Sang.Text == "Binary")
                    {
                        int DecimalValue = Convert.ToInt32(input_str, 16);
                        string BinaryValue = Convert.ToString(DecimalValue, 2);
                        textBox_KetQua.Text = BinaryValue;
                    }
                    //Chuyển từ dạng hexadecimal sang decimal
                    else if (comboBox_Sang.Text == "Decimal")
                    {
                        int DecimalValue = Convert.ToInt32(input_str, 16);
                        textBox_KetQua.Text = DecimalValue.ToString();
                    }
                }
            }
        }
    }
}
