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
    public class DAL_CTPhieuNhap : Connect_Close_DB, Interface_CTPhieuNhap
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dtS = new DataTable();
        DataTable dtCTPN = new DataTable();
        public bool addS(DTO_CTPhieuNhap ctpn)
        {
            int tmp = 0;
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT soLuongTon FROM TblSach WHERE maSach = '{ctpn.maS}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetInt32(0);
            }
            rd.Close();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblSach SET soLuongTon = {tmp + ctpn.soLuong} WHERE maSach = '{ctpn.maS}'";
            int ktr = cmd.ExecuteNonQuery();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblCTPhieuNhap VALUES ('{ctpn.maPN}', '{ctpn.maS}', {ctpn.soLuong}, {ctpn.giaNhap})";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0 && ktr > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool editS(DTO_CTPhieuNhap ctpn, int slf)
        {
            connect_DB();
            int tmp = 0;
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT soLuongTon FROM TblSach WHERE maSach = '{ctpn.maS}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetInt32(0);
            }
            rd.Close();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblSach SET soLuongTon = {tmp - slf + ctpn.soLuong} WHERE maSach = '{ctpn.maS}'";
            int ktr = cmd.ExecuteNonQuery();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblCTPhieuNhap SET soLuongNhap = {ctpn.soLuong}, giaNhap = {ctpn.giaNhap} WHERE maPN = '{ctpn.maPN}' AND maSach = '{ctpn.maS}'";
            int kt = cmd.ExecuteNonQuery();

            if (kt > 0 && ktr > 0)
            {
                return true;
            }
            Close_DB();
            return false;
        }
        public string getGiaNhap(int sl, string maS)
        {
            connect_DB();
            int giaNhap = 0;
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT giaNhap FROM TblSach WHERE maSach = '{maS}'";
            var rdgn = cmd.ExecuteReader();
            while(rdgn.Read())
            {
                giaNhap = rdgn.GetInt32(0);
            }
            rdgn.Close();
            Close_DB();
            return Convert.ToString(sl*giaNhap);
        }

        public bool deleteS(DTO_CTPhieuNhap ctpn)
        {
            connect_DB();
            int tmp = 0;
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT soLuongTon FROM TblSach WHERE maSach = '{ctpn.maS}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetInt32(0);
            }
            rd.Close();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT SUM(soLuongNhap) FROM TblCTPhieuNhap WHERE maPN = '{ctpn.maPN}' AND maSach = '{ctpn.maS}'";
            var rds = cmd.ExecuteReader();
            while(rds.Read())
            {
                ctpn.soLuong = rds.GetInt32(0);
            }
            rds.Close();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblSach SET soLuongTon = {tmp - ctpn.soLuong} WHERE maSach = '{ctpn.maS}'";
            int ktr = cmd.ExecuteNonQuery();

            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblCTPhieuNhap WHERE maPN = '{ctpn.maPN}' AND maSach = '{ctpn.maS}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0 && ktr > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public DataTable searchTenS(string maPN, string tenS)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT S.maSach AS MA_SACH, S.tenSach AS TEN_SACH, S.soLuongTon AS SO_LUONG_TON, giaNhap AS GIA_NHAP, giaBan AS GIA_BAN FROM TblSach AS S
                                INNER JOIN TblNhaXuatBan AS NXB
                                ON NXB.maNXB = S.maNXB
                                INNER JOIN TblPhieuNhap AS PN
                                ON PN.maNXB = NXB.maNXB
                                WHERE PN.maPN = '{maPN}' AND S.tenSach LIKE N'%{tenS}%'";
            adt.SelectCommand = cmd;
            dtS.Clear();
            adt.Fill(dtS);
            Close_DB();
            return dtS;
        }

        public DataTable showCTPN(string maPN)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maPN AS MA_PHIEU_NHAP, maSach AS MA_SACH, soLuongNhap AS SO_LUONG_NHAP, giaNhap AS GIA_NHAP 
                                FROM TblCTPhieuNhap 
                                WHERE maPN = '{maPN}'";
            adt.SelectCommand = cmd;
            dtCTPN.Clear();
            adt.Fill(dtCTPN);
            Close_DB();
            return dtCTPN;
        }

        public DataTable showSach(string maPN)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT S.maSach AS MA_SACH, S.tenSach AS TEN_SACH, S.soLuongTon AS SO_LUONG_TON, giaNhap AS GIA_NHAP, giaBan AS GIA_BAN FROM TblSach AS S
                                INNER JOIN TblNhaXuatBan AS NXB
                                ON NXB.maNXB = S.maNXB
                                INNER JOIN TblPhieuNhap AS PN
                                ON PN.maNXB = NXB.maNXB
                                WHERE PN.maPN = '{maPN}'";
            adt.SelectCommand = cmd;
            dtS.Clear();
            adt.Fill(dtS);
            Close_DB();
            return dtS;
        }
        public bool updateTongPN(DTO_CTPhieuNhap ctpn)
        {
            long tmp = 0;
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT SUM(giaNhap) FROM TblCTPhieuNhap WHERE maPN = '{ctpn.maPN}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetInt64(0);
            }
            rd.Close();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblPhieuNhap SET tongTien = {tmp} WHERE maPN = '{ctpn.maPN}'";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }
        public bool updateTongPN(string maPN, int tmp)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblPhieuNhap SET tongTien = {tmp} WHERE maPN = '{maPN}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }
    }
}
