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
    public class DAL_QLBanSach : Connect_Close_DB, Interface_QLBanSach
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public bool addHD(DTO_QLBanSach hd)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblHoaDon VALUES ('{hd.maHD}', '{hd.ngayBan}', '{hd.maNV}', {hd.tongTien})";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool deleteHD(DTO_QLBanSach hd)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblCTHoaDon WHERE maHD = '{hd.maHD}'";
            int ktr = cmd.ExecuteNonQuery();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblHoaDon WHERE maHD = '{hd.maHD}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0 && ktr > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool editHD(DTO_QLBanSach hd)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblHoaDon SET ngayBan = '{hd.ngayBan}', maNV = '{hd.maNV}', tongTien = {hd.tongTien} WHERE maHD = '{hd.maHD}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public string getMaNV(string tk)
        {
            string tmp = "";
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maNV FROM TblTaiKhoan WHERE id = '{tk}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            Close_DB();
            return tmp;
        }

        public DataTable searchHD(string maHD)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maHD AS MA_HOA_DON, ngayBan AS NGAY_BAN, maNV AS MA_NHAN_VIEN, tongTien AS TONG_TIEN FROM TblHoaDon
                                WHERE maHD LIKE '%{maHD}%'";
            adt.SelectCommand = cmd;
            var dts = new DataTable();
            dts.Clear();
            adt.Fill(dts);
            Close_DB();
            return dts;
        }

        public DataTable showHD()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maHD AS MA_HOA_DON, ngayBan AS NGAY_BAN, maNV AS MA_NHAN_VIEN, tongTien AS TONG_TIEN FROM TblHoaDon";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            Close_DB();
            return dt;
        }

        public DataTable inHD(DTO_QLBanSach hd)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT TblSach.tenSach, SUM(TblCTHoaDon.soLuong), TblSach.giaBan, SUM(TblCTHoaDon.thanhTien)
                                FROM TblCTHoaDon 
                                INNER JOIN TblHoaDon ON TblCTHoaDon.maHD = TblHoaDon.maHD 
                                INNER JOIN TblSach ON TblCTHoaDon.maSach = TblSach.maSach
                                WHERE TblHoaDon.maHD = '{hd.maHD}'
                                GROUP BY tenSach, giaBan";
            adt.SelectCommand = cmd;
            var inHD = new DataTable();
            inHD.Clear();
            adt.Fill(inHD);
            Close_DB();
            return inHD;
        }
    }
}
