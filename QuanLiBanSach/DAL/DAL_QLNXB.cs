using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_QLNXB : Connect_Close_DB, Interface_QLNXB
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public bool addNXB(DTO_QLNXB nxb)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblNhaXuatBan VALUES ('{nxb.maNXB}', N'{nxb.tenNXB}', '{nxb.dienThoai}', N'{nxb.diaChi}')";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool deleteNXB(DTO_QLNXB nxb)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblNhaXuatBan WHERE maNXB = '{nxb.maNXB}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool editNXB(DTO_QLNXB nxb)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblNhaXuatBan SET tenNXB = N'{nxb.tenNXB}', dienThoai = '{nxb.dienThoai}', diaChi = N'{nxb.diaChi}' WHERE maNXB = '{nxb.maNXB}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public DataTable searchMaNXB(string maNXB)
        {
            var dtMa = new DataTable();
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maNXB AS MA_NXB, tenNXB AS TEN_NXB, dienThoai AS DIEN_THOAI, diaChi AS DIA_CHI FROM TblNhaXuatBan WHERE maNXB LIKE '%{maNXB}%'";
            adt.SelectCommand = cmd;
            dtMa.Clear();
            adt.Fill(dtMa);
            Close_DB();
            return dtMa;
        }

        public DataTable searchTenNXB(string tenNXB)
        {
            var dtTen = new DataTable();
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maNXB AS MA_NXB, tenNXB AS TEN_NXB, dienThoai AS DIEN_THOAI, diaChi AS DIA_CHI FROM TblNhaXuatBan WHERE tenNXB LIKE '%{tenNXB}%'";
            adt.SelectCommand = cmd;
            dtTen.Clear();
            adt.Fill(dtTen);
            Close_DB();
            return dtTen;
        }

        public DataTable showNXB()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maNXB AS MA_NXB, tenNXB AS TEN_NXB, dienThoai AS DIEN_THOAI, diaChi AS DIA_CHI FROM TblNhaXuatBan";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            Close_DB();
            return dt;
        }
    }
}
