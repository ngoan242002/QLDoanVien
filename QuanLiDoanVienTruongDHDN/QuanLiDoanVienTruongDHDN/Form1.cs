using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDoanVienTruongDHDN
{
    public partial class FormDangNhap : Form
    {
        DoanVienDAO doanVienDAO;

        public FormDangNhap()
        {
            doanVienDAO = new DoanVienDAO();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.taiKhoan = doanVienDAO.login(textBox1.Text.Trim(), textBox2.Text.Trim());
            if (Program.taiKhoan == null)
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");

            }
            else
            {
                // MessageBox.Show("Dang nhap thanh cong"); 
                FormMain form = new FormMain();
                form.Show();
            }

        }
    }
}
