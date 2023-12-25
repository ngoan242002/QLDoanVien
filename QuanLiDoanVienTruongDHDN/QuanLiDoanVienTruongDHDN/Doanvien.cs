using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDoanVienTruongDHDN
{
    class Doanvien
    {
        int MaDV;
        string HoTen;
        DateTime NgaySinh;
        string GioiTinh;
        string DiaChi;
        int SDT;
        string DanToc;
        string MaXL;
        string MaKH;
        string TenChiDoan;
        DateTime NgayVaoDoan;

        public int MaDV1 { get => MaDV; set => MaDV = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int SDT1 { get => SDT; set => SDT = value; }
        public string DanToc1 { get => DanToc; set => DanToc = value; }
        public string MaXL1 { get => MaXL; set => MaXL = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenChiDoan1 { get => TenChiDoan; set => TenChiDoan = value; }
        public DateTime NgayVaoDoan1 { get => NgayVaoDoan; set => NgayVaoDoan = value; }

        public Doanvien(int maDV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, int sDT, string danToc, string maXL, string maKH, string tenChiDoan, DateTime ngayVaoDoan)
        {
            MaDV1 = maDV;
            HoTen1 = hoTen;
            NgaySinh1 = ngaySinh;
            GioiTinh1 = gioiTinh;
            DiaChi1 = diaChi;
            SDT1 = sDT;
            DanToc1 = danToc;
            MaXL1 = maXL;
            MaKH1 = maKH;
            TenChiDoan1 = tenChiDoan;
            NgayVaoDoan1 = ngayVaoDoan;
        }

        public Doanvien()
        {
        }
    }
}
