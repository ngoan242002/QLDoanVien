using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDoanVienTruongDHDN
{
    class DoanVienDAO
    {
        private SqlConnection connection;
        private const string DATE_FORMAT = "yyyy-MM-dd";
        private const string CONNECTION_STRING = @"Data Source=ADMIN\MSSQLSERVER02;Initial Catalog=QLDVCAP3;Integrated Security=True";

        public DoanVienDAO()
        {
            connection = new SqlConnection(CONNECTION_STRING);
        }

        public TaiKhoanObj login(string taiKhoan, string matKhau)
        {
            List<TaiKhoanObj> taiKhoans = new List<TaiKhoanObj>();
            try
            {
                string query = "select * from TaiKhoan where taiKhoan = '" + taiKhoan + "' and matKhau = '" + matKhau + "'";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    taiKhoans.Add(
                        new TaiKhoanObj(reader["taiKhoan"].ToString(),
                        reader["matKhau"].ToString(),
                        Int32.Parse(reader["MaDV"].ToString())));
                }
                connection.Close();
                if (taiKhoans.Count > 0)
                {
                    return taiKhoans[0];
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public List<Doanvien> GetDoanviens()
        {
            List<Doanvien> list = new List<Doanvien>();
            try
            {
                string query = $"select * from THONGTINDOANVIEN";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Doanvien(
                            Int32.Parse(reader["MaDV"].ToString()),
                            reader["HoTen"].ToString(),
                            DateTime.Parse(reader["NgaySinh"].ToString()),
                            reader["GioiTinh"].ToString(),
                            reader["DiaChi"].ToString(),
                            Int32.Parse(reader["SDT"].ToString()),
                            reader["DanToc"].ToString(),
                            reader["MaXL"].ToString(),
                            reader["MaKH"].ToString(),
                            reader["TenChiDoan"].ToString(),
                            DateTime.Parse(reader["NgayVaoDoan"].ToString())));
                }
                connection.Close();
            }
            catch (Exception e)
            {
            }
            return list;
        }

        public Doanvien getDoanVien(int ID)
        {
            Doanvien doanvien = new Doanvien();
            try
            {
                string query = $"select * from THONGTINDOANVIEN where MaDV = {ID}";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    doanvien = new Doanvien(
                            Int32.Parse(reader["MaDV"].ToString()),
                            reader["HoTen"].ToString(),
                            DateTime.Parse(reader["NgaySinh"].ToString()),
                            reader["GioiTinh"].ToString(),
                            reader["DiaChi"].ToString(),
                            Int32.Parse(reader["SDT"].ToString()),
                            reader["DanToc"].ToString(),
                            reader["MaXL"].ToString(),
                            reader["MaKH"].ToString(),
                            reader["TenChiDoan"].ToString(),
                            DateTime.Parse(reader["NgayVaoDoan"].ToString()));
                }
                connection.Close();
            }
            catch (Exception e)
            {
            }
            return doanvien;
        }
        public thongtingiadinh getthongtingiadinh(int MaDV)
        {
            thongtingiadinh thongtingiadinh = new thongtingiadinh();
            try
            {
                string query = $"select * from GIADINHDV where MaDV = {MaDV}";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    thongtingiadinh = new thongtingiadinh(
                            reader["MaGD"].ToString(),
                            reader["TenBo"].ToString(),
                            DateTime.Parse(reader["NgaySinhBo"].ToString()),
                            reader["TenMe"].ToString(),
                            DateTime.Parse(reader["NgaySinhMe"].ToString()),
                            reader["NNbo"].ToString(),
                            reader["NNme"].ToString(),
                            Int32.Parse(reader["SoThanhVien"].ToString()),
                            Int32.Parse(reader["MaDV"].ToString())
                        );
                }
                connection.Close();
            }
            catch (Exception e)
            {
            }
            return thongtingiadinh;
        }
        public Thongtinkhoahoc getThongtinkhoahoc(string MaKH)
        {
            Thongtinkhoahoc thongtinkhoahoc = new Thongtinkhoahoc();
            try
            {
                string query = $"select * from TTKhoaHoc where MaKH = '{MaKH}'";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    thongtinkhoahoc = new Thongtinkhoahoc(
                            reader["MaKH"].ToString(),
                            reader["TenKH"].ToString(),
                            reader["MaChiDoan"].ToString(),
                            reader["MaSK"].ToString()
                        );
                }
                connection.Close();
            }
            catch (Exception e)
            {
            }
            return thongtinkhoahoc;
        }
        public Xeploai getXeploai(string MaXL)
        {
            Xeploai xeploai = new Xeploai();
            try
            {
                string query = $"select * from XepLoai where MaXL = '{MaXL}'";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    xeploai = new Xeploai(
                            reader["MaXL"].ToString(),
                            reader["TenXL"].ToString(),
                            reader["ChiDoan"].ToString()
                        );
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return xeploai;
        }
        public bool updateDoanVien(Doanvien doanvienHienTai, Doanvien doanvienMoi)
        {
            try
            {
                string query = $"update THONGTINDOANVIEN set " +
                    $"HoTen = N'{doanvienMoi.HoTen1}', " +
                    $"NgaySinh = '{doanvienMoi.NgaySinh1.ToString(DATE_FORMAT)}', " + 
                    $"GioiTinh = N'{doanvienMoi.GioiTinh1}', " +
                    $"DiaChi = N'{doanvienMoi.DiaChi1}', " +
                    $"SDT = {doanvienMoi.SDT1}, " +
                    $"DanToc = N'{doanvienMoi.DanToc1}', " +
                    $"MaXL = '{doanvienMoi.MaXL1}', " +
                    $"MaKH = '{doanvienMoi.MaKH1}', " +
                    $"TenChiDoan = N'{doanvienMoi.TenChiDoan1}', " +
                    $"NgayVaoDoan = '{doanvienMoi.NgayVaoDoan1.ToString(DATE_FORMAT)}' " + 
                    $"where MaDV = {doanvienHienTai.MaDV1}";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(@query, connection);
                if (sqlCommand.ExecuteNonQuery() < 0)
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();
                    return true;

                }
            }
            catch (Exception e)
            {

                return false;
            }
        }
        public bool add(Doanvien doanvien)
        {
            try
            {
                string query = $"insert into THONGTINDOANVIEN values (" +
                    $"{doanvien.MaDV1}, " +
                    $"N'{doanvien.HoTen1}', " +
                    $"'{doanvien.NgaySinh1.ToString(DATE_FORMAT)}', " +
                    $"N'{doanvien.GioiTinh1}', " +
                    $"N'{doanvien.DiaChi1}', " +
                    $"{doanvien.SDT1}, " +
                    $"N'{doanvien.DanToc1}', " +
                    $"'{doanvien.MaXL1}', " +
                    $"'{doanvien.MaKH1}', " +
                    $"N'{doanvien.TenChiDoan1}', " +
                    $"'{doanvien.NgayVaoDoan1.ToString(DATE_FORMAT)}'" +
                    $")";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if (sqlCommand.ExecuteNonQuery() < 0)
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<Thongtinkhoahoc> getKhoahocs()
        {
            List<Thongtinkhoahoc> thongtinkhoahocs = new List<Thongtinkhoahoc>();
            try
            {
                string query = $"select * from TTKhoaHoc";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Thongtinkhoahoc thongtinkhoahoc = new Thongtinkhoahoc(
                                                reader["MaKH"].ToString(),
                                                reader["TenKH"].ToString(),
                                                reader["MaChiDoan"].ToString(),
                                                reader["MaSK"].ToString()
                                            );
                    thongtinkhoahocs.Add(thongtinkhoahoc);
                }
                connection.Close();
            }
            catch (Exception e)
            {
            }
            return thongtinkhoahocs;
        }
        public List<Xeploai> GetXeploais()
        {
            List<Xeploai> list = new List<Xeploai>();
            try
            {
                string query = $"select * from XepLoai";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Xeploai xeploai = new Xeploai(
                                                reader["MaXL"].ToString(),
                                                reader["TenXL"].ToString(),
                                                reader["ChiDoan"].ToString()
                                            );
                    list.Add(xeploai);
                }
                connection.Close();
            }
            catch (Exception e)
            {
            }
            return list;
        }
        public bool delete(int id, string tbName)
        {
            try
            {
                string query = $"delete from {tbName} where MaDV = {id}";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if (sqlCommand.ExecuteNonQuery() < 0)
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();
                    return true;

                }
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show(e.Message);
                return false
;
            }
        }
    }
}
