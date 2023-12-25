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
    public partial class FormMain : Form
    {

        DoanVienDAO doanVienDAO;
        Doanvien doanvien;
        thongtingiadinh mthongtingiadinh;
        Thongtinkhoahoc mthongtinkhoahoc;

        public FormMain()
        {
            doanVienDAO = new DoanVienDAO();
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcThongTin.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(tcThongTin);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tcThongTin.Visible = false;

            doanvien = doanVienDAO.getDoanVien(Program.taiKhoan.MaDv);
            MaDV.Text = doanvien.MaDV1.ToString();
            HoTen.Text = doanvien.HoTen1;
            NgaySinh.Text = doanvien.NgaySinh1.ToString("dd/MM/yyyy");
            GioiTinh.Text = doanvien.GioiTinh1;
            DiaChi.Text = doanvien.DiaChi1;
            SDT.Text = doanvien.SDT1.ToString();
            DanToc.Text = doanvien.DanToc1;
            ChiDoan.Text = doanvien.TenChiDoan1;
            NgayVaoDoan.Text = doanvien.NgayVaoDoan1.ToString("dd/MM/yyyy");

            mthongtingiadinh = doanVienDAO.getthongtingiadinh(doanvien.MaDV1);
            hotenbo.Text = mthongtingiadinh.TenBo1;
            ngaysinhbo.Text = mthongtingiadinh.NgaySinhBo1.ToString("dd/MM/yyyy");
            hotenme.Text = mthongtingiadinh.TenMe1;
            ngaysinhme.Text = mthongtingiadinh.NgaySinhMe1.ToString("dd/MM/yyyy");
            nghebo.Text = mthongtingiadinh.NNbo1;
            ngheme.Text = mthongtingiadinh.NNme1;
            sothanhvien.Text = mthongtingiadinh.SoThanhVien1.ToString();

            mthongtinkhoahoc = doanVienDAO.getThongtinkhoahoc(doanvien.MaKH1);
            Makh.Text = mthongtinkhoahoc.MaKH1;
            tenkhoahoc.Text = mthongtinkhoahoc.TenKH1;
            machidoan.Text = mthongtinkhoahoc.MaChiDoan1;
            masukien.Text = mthongtinkhoahoc.MaSK1;

   

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void MaDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void thongtingiadinh_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DanhSachBoSung danhSachBoSung = new DanhSachBoSung();
            danhSachBoSung.TopLevel = false;
            danhSachBoSung.AutoScroll = true;
            danhSachBoSung.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(danhSachBoSung);
            danhSachBoSung.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            XeploaiDV formXepLoai = new XeploaiDV(doanVienDAO.getXeploai(doanvien.MaXL1));
            formXepLoai.TopLevel = false;
            formXepLoai.AutoScroll = true;
            panel1.Controls.Add(formXepLoai);
            formXepLoai.Show();
        }
    }
}
