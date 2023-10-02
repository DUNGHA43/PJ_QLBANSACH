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
    public class DAL_QLPhieuNhap : Connect_Close_DB, Interface_QLPhieuNhap
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public bool addPN(DTO_QLPhieuNhap pn)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblPhieuNhap VALUES ('{pn.maPN}', '{pn.ngayNhap}', '{pn.maNXB}', '{pn.maNV}', {pn.tongTien})";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool deletePN(DTO_QLPhieuNhap pn)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblCTPhieuNhap WHERE maPN = '{pn.maPN}'";
            int ktr = cmd.ExecuteNonQuery();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblPhieuNhap WHERE maPN = '{pn.maPN}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0 && ktr > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool editPN(DTO_QLPhieuNhap pn)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblPhieuNhap SET ngayNhap = '{pn.ngayNhap}', maNXB = '{pn.maNXB}', maNV = '{pn.maNV}' WHERE maPN = '{pn.maPN}'";
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
            while(rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            Close_DB();
            return tmp;
        }

        public string getMaNXB(string tenNXB)
        {
            string tmp = "";
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maNXB FROM TblNhaXuatBan WHERE tenNXB = '{tenNXB}'";
            var rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            Close_DB();
            return tmp;
        }

        public DataTable loadTenNXB()
        {
            var dtTenNXB = new DataTable();
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT tenNXB FROM TblNhaXuatBan";
            adt.SelectCommand = cmd;
            dtTenNXB.Clear();
            adt.Fill(dtTenNXB);
            Close_DB();
            return dtTenNXB;
        }

        public DataTable searchPN(string maPN)
        {
            var dts = new DataTable();
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maPN AS MA_PHIEU_NHAP, ngayNhap AS NGAY_NHAP, NXB.tenNXB AS TEN_NXB, maNV AS MA_NV, tongTien AS TONG_TIEN 
                                    FROM TblPhieuNhap AS PN
                                    INNER JOIN TblNhaXuatBan AS NXB
                                    ON NXB.maNXB = PN.maNXB 
                                    WHERE PN.maPN LIKE '%{maPN}%'";
            adt.SelectCommand = cmd;
            dts.Clear();
            adt.Fill(dts);
            Close_DB();
            return dts;
        }

        public DataTable showPN()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maPN AS MA_PHIEU_NHAP, ngayNhap AS NGAY_NHAP, NXB.tenNXB AS TEN_NXB, maNV AS MA_NV, tongTien AS TONG_TIEN 
                                    FROM TblPhieuNhap AS PN
                                    INNER JOIN TblNhaXuatBan AS NXB
                                    ON NXB.maNXB = PN.maNXB";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            Close_DB();
            return dt;
        }
    }
}
