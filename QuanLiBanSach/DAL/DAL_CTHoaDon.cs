using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class DAL_CTHoaDon : Connect_Close_DB, Interface_CTHoaDon
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dtcthd = new DataTable();
        DataTable dtS = new DataTable();
        public bool addS(DTO_CTHoaDon cthd)
        {
            int tmp = 0;
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT soLuongTon FROM TblSach WHERE maSach = '{cthd.maS}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetInt32(0);
            }
            rd.Close();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblSach SET soLuongTon = {tmp - cthd.sL} WHERE maSach = '{cthd.maS}'";
            int ktr = cmd.ExecuteNonQuery();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblCTHoaDon VALUES ('{cthd.maHD}', '{cthd.maS}', {cthd.sL}, {cthd.giaTien})";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0 && ktr > 0)
            {
                Close_DB();
                return true;
            }
            return false;
        }

        public bool deleteS(DTO_CTHoaDon cthd)
        {
            int tmp = 0;
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT soLuongTon FROM TblSach WHERE maSach = '{cthd.maS}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetInt32(0);
            }
            rd.Close();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblSach SET soLuongTon = {tmp + cthd.sL} WHERE maSach = '{cthd.maS}'";
            int ktr = cmd.ExecuteNonQuery();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblCTHoaDon WHERE maHD = '{cthd.maHD}'and maSach = '{cthd.maS}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0 && ktr > 0)
            {
                Close_DB();
                return true;
            }
            return false;
        }

        public string getGiaBan(int sl, string maS)
        {
            connect_DB();
            int giaBan = 0;
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT giaBan FROM TblSach WHERE maSach = '{maS}'";
            var rdgn = cmd.ExecuteReader();
            while (rdgn.Read())
            {
                giaBan = rdgn.GetInt32(0);
            }
            rdgn.Close();
            Close_DB();
            return Convert.ToString(sl * giaBan);
        }

        public DataTable searchTenS(string tenS)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT S.maSach AS MA_SACH, S.tenSach AS TEN_SACH, S.soLuongTon AS SO_LUONG_TON, giaNhap AS GIA_NHAP, giaBan AS GIA_BAN FROM TblSach AS S
                                    WHERE S.tenSach LIKE N'%{tenS}%'";
            adt.SelectCommand = cmd;
            dtS.Clear();
            adt.Fill(dtS);
            Close_DB();
            return dtS;
        }

        public DataTable showCTHD(string maHD)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maHD AS MA_HOA_DON, CTHD.maSach AS MA_SACH, SUM(soLuong) AS SO_LUONG, S.giaBan AS GIA_BAN,SUM(CTHD.thanhTien) AS THANH_TIEN FROM TblCTHoaDon AS CTHD
                                    INNER JOIN TblSach AS S
                                    ON S.maSach = CTHD.maSach
                                    WHERE CTHD.maHD = '{maHD}'
                                    GROUP BY maHD, CTHD.maSach, S.giaBan";
            adt.SelectCommand = cmd;
            dtcthd.Clear();
            adt.Fill(dtcthd);
            Close_DB();
            return dtcthd;
        }

        public DataTable showSach()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT S.maSach AS MA_SACH, S.tenSach AS TEN_SACH, S.soLuongTon AS SO_LUONG_TON, giaNhap AS GIA_NHAP, giaBan AS GIA_BAN FROM TblSach AS S";
            adt.SelectCommand = cmd;
            dtS.Clear();
            adt.Fill(dtS);
            Close_DB();
            return dtS;
        }

        public bool updateTongHD(DTO_CTHoaDon cthd)
        {
            long tmp = 0;
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT SUM(thanhTien) FROM TblCTHoaDon WHERE maHD = '{cthd.maHD}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetInt64(0);
            }
            rd.Close();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblHoaDon SET tongTien = {tmp} WHERE maHD = '{cthd.maHD}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            return false;
        }

        public bool updateTongHD(string maHD, int tmp)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblHoaDon SET tongTien = {tmp} WHERE maHD = '{maHD}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            return false;
        }
    }
}
