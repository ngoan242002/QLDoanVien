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
    public partial class DanhSachBoSung : Form
    {
        private static Doanvien doanvienThem;
        private static Doanvien doanvienSua;
        private static Doanvien currentDVClicked;
        private DoanVienDAO doanvienDAO;
        private BindingSource bindingSource = new BindingSource();
        private int index = -1;
        private List<Doanvien> doanvienList = new List<Doanvien>();
        private List<Thongtinkhoahoc> thongtinkhoahocs = new List<Thongtinkhoahoc>();
        private List<Xeploai> xeploais = new List<Xeploai>();

        public DanhSachBoSung()
        {
            init();
            InitializeComponent();
            
        }

        private void init()
        {
            doanvienThem = new Doanvien();
            doanvienSua = new Doanvien();
            currentDVClicked = new Doanvien();
            doanvienDAO = new DoanVienDAO();
        }

        ~DanhSachBoSung()
        {
            doanvienThem = null;
            doanvienSua = null;
            currentDVClicked = null;
        } 
        private void DanhSachBoSung_Load(object sender, EventArgs e)
        {
            thongtinkhoahocs.Clear();
            xeploais.Clear();
            updateViewTable();
            thongtinkhoahocs.AddRange(doanvienDAO.getKhoahocs());
            xeploais.AddRange(doanvienDAO.GetXeploais());
            cbKH.Items.Clear();
            cbKH.Items.AddRange(thongtinkhoahocs.ToArray());
            cbXl.Items.Clear();
            cbXl.Items.AddRange(xeploais.ToArray());
            setDataClick(null);
        }

        private void updateViewTable()
        {
            doanvienList.Clear();
            bindingSource.Clear();
            doanvienList.AddRange(doanvienDAO.GetDoanviens());
            foreach (Doanvien item in doanvienList)
            {
                bindingSource.Add(item);
            }
            dgDoanvien.DataSource = bindingSource;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                currentDVClicked = doanvienList[index];
                setDataClick(currentDVClicked);
                dgDoanvien.Rows[e.RowIndex].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setDataClick(Doanvien doanvien)
        {
            if (doanvien == null)
            {
                maDv.Clear();
                hoTen.Clear();
                ngaySinh.Value = DateTime.Now;
                gioiTinh.Clear();
                diaChi.Clear();
                soDienThoai.Clear();
                danToc.Clear();
                chiDoan.Clear();
                ngayVaoDoan.Value = DateTime.Now;
                //cbKH.SelectedIndex = 0;
                //cbXl.SelectedIndex = 0;
                return;

            }
            maDv.Text = doanvien.MaDV1.ToString();
            hoTen.Text = doanvien.HoTen1.ToString();
            ngaySinh.Value = doanvien.NgaySinh1.Date;
            gioiTinh.Text = doanvien.GioiTinh1;
            diaChi.Text = doanvien.DiaChi1;
            soDienThoai.Text = doanvien.SDT1.ToString();
            danToc.Text = doanvien.DanToc1;
            chiDoan.Text = doanvien.TenChiDoan1;
            ngayVaoDoan.Value = doanvien.NgayVaoDoan1.Date;
            foreach (Thongtinkhoahoc item in thongtinkhoahocs)
            {
                if (doanvien.MaKH1 == item.MaKH1)
                {
                    cbKH.SelectedIndex = thongtinkhoahocs.IndexOf(item);

                    break;

                }
            }
            foreach (Xeploai item in xeploais)
            {
                if (doanvien.MaXL1 == item.MaXL1)
                {
                    cbXl.SelectedIndex = xeploais.IndexOf(item);
                    break;
                }
            }
        }

        private Doanvien getDataClick()
        {
            Doanvien doanvien = new Doanvien();
            try
            {

                doanvien = new Doanvien(
                                Int32.Parse(maDv.Text),
                                hoTen.Text,
                                ngaySinh.Value,
                                gioiTinh.Text,
                                diaChi.Text,
                                Int32.Parse(soDienThoai.Text),
                                danToc.Text,
                                xeploais[cbXl.SelectedIndex].MaXL1,
                                thongtinkhoahocs[cbKH.SelectedIndex].MaKH1,
                                chiDoan.Text,
                                ngayVaoDoan.Value
                                );
            }
            catch (Exception)
            {

            }
            return doanvien;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            getDoanVienThem();
            if (doanvienDAO.add(doanvienThem))
            {
                updateViewTable();
            }
            else MessageBox.Show("erro");
            setDataClick(null);

        }

        private void getDoanVienThem()
        {
            doanvienThem = getDataClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getDoanVienSua();
            if (doanvienDAO.updateDoanVien(currentDVClicked, doanvienSua))
            {
                updateViewTable();
            }
            else MessageBox.Show("erro");
            setDataClick(null);
        }

        private void getDoanVienSua()
        {
            doanvienSua = getDataClick();
        }

        private void soDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentDVClicked != null)
            {
                if (
                    doanvienDAO.delete(currentDVClicked.MaDV1, "TaiKhoan") &&
                    doanvienDAO.delete(currentDVClicked.MaDV1, "GIADINHDV") &&
                    doanvienDAO.delete(currentDVClicked.MaDV1, "DanhSachBoSung")
                    )
                {
                    doanvienDAO.delete(currentDVClicked.MaDV1, "THONGTINDOANVIEN");
                    updateViewTable();
                    ////setDataClick(null);
                }
            }
            setDataClick(null);
        }
    }
}
