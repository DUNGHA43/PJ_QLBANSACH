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
    public class DAL_QLSach : Connect_Close_DB, Interface_QLSach
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public bool addSach(DTO_QLSach s)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblSach VALUES ('{s.maS}', N'{s.tenS}', {s.soLuongTon}, {s.giaNhap}, {s.giaBan}, '{s.maTL}', '{s.maTG}', '{s.maNXB}')";
            int kt = cmd.ExecuteNonQuery();
            if(kt >0 ) 
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool deleteSach(DTO_QLSach s)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblSach WHERE maSach = '{s.maS}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool editSach(DTO_QLSach s)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblSach SET tenSach = N'{s.tenS}', soLuongTon = {s.soLuongTon}, giaNhap = {s.giaNhap}, giaBan = {s.giaBan}, maTL = '{s.maTL}', maTG = '{s.maTG}', maNXB = '{s.maNXB}' WHERE maSach = '{s.maS}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public string loadMaNXB(string tenNXB)
        {
            string tmp ="";
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maNXB FROM TblNhaXuatBan WHERE tenNXB = N'{tenNXB}'";
            var rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                tmp = rd.GetString(0);
            }
            Close_DB();
            return tmp;
        }

        public string loadMaTG(string tenTG)
        {
            string tmp = "";
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maTG FROM TblTacGia WHERE tenTG = N'{tenTG}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetString(0);
            }
            Close_DB();
            return tmp;
        }

        public string loadMaTL(string tenTL)
        {
            string tmp = "";
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maTL FROM TblTheLoai WHERE tenTL = N'{tenTL}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetString(0);
            }
            Close_DB();
            return tmp;
        }

        public DataTable loadTenNXB()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT tenNXB FROM TblNhaXuatBan";
            adt.SelectCommand = cmd;
            var dtNXB = new DataTable();
            dtNXB.Clear();
            adt.Fill(dtNXB);
            Close_DB();
            return dtNXB;
        }

        public DataTable loadTenTG()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT tenTG FROM TblTacGia";
            adt.SelectCommand = cmd;
            var dtTG = new DataTable();
            dtTG.Clear();
            adt.Fill(dtTG);
            Close_DB();
            return dtTG;
        }

        public DataTable loadTenTL()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT tenTL FROM TblTheLoai";
            adt.SelectCommand = cmd;
            var dtTL = new DataTable();
            dtTL.Clear();
            adt.Fill(dtTL);
            Close_DB();
            return dtTL;
        }

        public DataTable searchSach(string maS, string tenS, string tl, string tg)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maSach AS MA_SACH, tenSach AS TEN_SACH, soLuongTon AS SO_LUONG_TON, giaNhap AS GIA_NHAP,  giaBan AS GIA_BAN, TL.tenTL AS TEN_TL, TG.tenTG AS TEN_TG, NXB.tenNXB AS TEN_NXB
                                 FROM TblSach AS S
                                 INNER JOIN TblTheLoai AS TL
                                 ON TL.maTL = S.maTL
                                 INNER JOIN TblTacGia AS TG
                                 ON TG.maTG = S.maTG
                                 INNER JOIN TblNhaXuatBan AS NXB
                                 ON NXB.maNXB = S.maNXB
                                 WHERE S.maSach LIKE '%{maS}%' AND S.tenSach LIKE N'%{tenS}%' AND tenTL LIKE N'%{tl}%' AND tenTG LIKE N'%{tg}%'";
            adt.SelectCommand = cmd;
            var dtsS = new DataTable();
            dtsS.Clear();
            adt.Fill(dtsS);
            Close_DB();
            return dtsS;
        }

        public DataTable showSach()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maSach AS MA_SACH, tenSach AS TEN_SACH, soLuongTon AS SO_LUONG_TON, giaNhap AS GIA_NHAP,  giaBan AS GIA_BAN, TL.tenTL AS TEN_TL, TG.tenTG AS TEN_TG, NXB.tenNXB AS TEN_NXB
                                    FROM TblSach AS S
                                    INNER JOIN TblTheLoai AS TL
                                    ON TL.maTL = S.maTL
                                    INNER JOIN TblTacGia AS TG
                                    ON TG.maTG = S.maTG
                                    INNER JOIN TblNhaXuatBan AS NXB
                                    ON NXB.maNXB = S.maNXB";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            Close_DB();
            return dt;
        }
    }
}
