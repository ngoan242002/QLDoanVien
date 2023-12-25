using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDoanVienTruongDHDN
{
    public class TaiKhoanObj
    {

        private string taiKhoan;
        private string matKhau;
        private int maDv;

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int MaDv { get => maDv; set => maDv = value; }

        public TaiKhoanObj(string taiKhoan, string matKhau, int maDv)
        {
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
            this.MaDv = maDv;
        }

        public TaiKhoanObj()
        {
        }


    }
}
