using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai8 : Form
    {
        public FormBai8()
        {
            InitializeComponent();
            this.Text = "Calculator"; 
        }

        // --- 1. Xử lý nút CỘNG ---
        private void btCong_Click(object sender, EventArgs e)
        {
            
            if (tbSoX.Text != "" && tbSoY.Text != "")
            {
                try
                {
                    
                    int x = int.Parse(tbSoX.Text);
                    int y = int.Parse(tbSoY.Text);

                    
                    int kq = x + y;

                    
                    tbKetQua.Text = kq.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ 2 số!");
            }
        }

        // --- 2. Xử lý nút NHÂN ---
        private void btNhan_Click(object sender, EventArgs e)
        {
            if (tbSoX.Text != "" && tbSoY.Text != "")
            {
                try
                {
                    int x = int.Parse(tbSoX.Text);
                    int y = int.Parse(tbSoY.Text);

                    int kq = x * y;

                    tbKetQua.Text = kq.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ 2 số!");
            }
        }

        // --- 3. Xử lý nút THOÁT ---
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}