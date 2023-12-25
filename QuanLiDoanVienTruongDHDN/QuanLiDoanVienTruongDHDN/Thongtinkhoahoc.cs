using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDoanVienTruongDHDN
{
    class Thongtinkhoahoc
    {
        string MaKH;
        string TenKH;
        string MaChiDoan;
        string MaSK;

        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string MaChiDoan1 { get => MaChiDoan; set => MaChiDoan = value; }
        public string MaSK1 { get => MaSK; set => MaSK = value; }

        public Thongtinkhoahoc(string maKH, string tenKH, string maChiDoan, string maSK)
        {
            MaKH1 = maKH;
            TenKH1 = tenKH;
            MaChiDoan1 = maChiDoan;
            MaSK1 = maSK;
        }

        public Thongtinkhoahoc()
        {
        }

        public override string ToString()
        {
            return TenKH;
        }
    }
}
