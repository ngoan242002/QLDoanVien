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
    public partial class FormXepLoai : Form
    {
        private Xeploai xeploai = new Xeploai();
        public FormXepLoai(Xeploai xeploai)
        {
            this.xeploai = xeploai;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaXL_Click(object sender, EventArgs e)
        {

        }

        private void FormXepLoai_Load(object sender, EventArgs e)
        {
            textMaxl.Text = xeploai.MaXL1;
            textTenxl.Text = xeploai.TenXL1;
            textChidoan.Text = xeploai.ChiDoan1;

        }

        private void textMaxl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
