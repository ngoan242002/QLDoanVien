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
    public partial class XeploaiDV : Form
    {

        private Xeploai xeploai;
        public XeploaiDV()
        {
            InitializeComponent();
        }

        public XeploaiDV(Xeploai xeploai)
        {
            this.xeploai = xeploai;
            InitializeComponent();
        }

        private void textMaXL_TextChanged(object sender, EventArgs e)
        {

        }

        private void XeploaiDV_Load(object sender, EventArgs e)
        {
            textMaXL.Text = xeploai.MaXL1;
            textTenXL.Text = xeploai.TenXL1;
            textChidoan.Text = xeploai.ChiDoan1;
        }
    }
}
