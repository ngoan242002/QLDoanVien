using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDoanVienTruongDHDN
{
    class thongtingiadinh
    {
        string MaGD;
        string TenBo;
        DateTime NgaySinhBo;
        string TenMe;
        DateTime NgaySinhMe;
        string NNbo;
        string NNme;
        int SoThanhVien;
        int MaDV;

        public string MaGD1 { get => MaGD; set => MaGD = value; }
        public string TenBo1 { get => TenBo; set => TenBo = value; }
        public DateTime NgaySinhBo1 { get => NgaySinhBo; set => NgaySinhBo = value; }
        public string TenMe1 { get => TenMe; set => TenMe = value; }
        public DateTime NgaySinhMe1 { get => NgaySinhMe; set => NgaySinhMe = value; }
        public string NNbo1 { get => NNbo; set => NNbo = value; }
        public string NNme1 { get => NNme; set => NNme = value; }
        public int SoThanhVien1 { get => SoThanhVien; set => SoThanhVien = value; }
        public int MaDV1 { get => MaDV; set => MaDV = value; }

        public thongtingiadinh(string maGD, string tenBo, DateTime ngaySinhBo, string tenMe, DateTime ngaySinhMe, string nNbo, string nNme, int soThanhVien, int maDV)
        {
            MaGD1 = maGD;
            TenBo1 = tenBo;
            NgaySinhBo1 = ngaySinhBo;
            TenMe1 = tenMe;
            NgaySinhMe1 = ngaySinhMe;
            NNbo1 = nNbo;
            NNme1 = nNme;
            SoThanhVien1 = soThanhVien;
            MaDV1 = maDV;
        }

        public thongtingiadinh()
        {
        }
    }
}
