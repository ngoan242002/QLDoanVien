using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDoanVienTruongDHDN
{
    public class Xeploai
    {
        string MaXL;
        string TenXL;
        string ChiDoan;

        public Xeploai(string maXL, string tenXL, string chiDoan)
        {
            MaXL1 = maXL;
            TenXL1 = tenXL;
            ChiDoan1 = chiDoan;
        }

        public Xeploai()
        {
        }

        public string MaXL1 { get => MaXL; set => MaXL = value; }
        public string TenXL1 { get => TenXL; set => TenXL = value; }
        public string ChiDoan1 { get => ChiDoan; set => ChiDoan = value; }

        public override string ToString()
        {
            return TenXL;
        }
    }
}
