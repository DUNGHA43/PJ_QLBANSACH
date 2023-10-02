using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_QLTL : Connect_Close_DB, Interface_QLTL
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public bool addTL(DTO_QLTL tl)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblTheLoai VALUES ('{tl.maTL}', N'{tl.tenTL}')";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool deleteTL(DTO_QLTL tl)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblTheLoai WHERE maTL = '{tl.maTL}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool editTL(DTO_QLTL tl)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblTheLoai SET tenTL = N'{tl.tenTL}' WHERE maTL = '{tl.maTL}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public DataTable searchMaTL(string maTL)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maTL AS MA_THE_LOAI, tenTL AS TEN_THE_LOAI FROM TblTheLoai WHERE maTL LIKE '%{maTL}%'";
            var dtMaTL = new DataTable();
            adt.SelectCommand = cmd;
            dtMaTL.Clear();
            adt.Fill(dtMaTL);
            Close_DB();
            return dtMaTL;
        }

        public DataTable searchTenTL(string tenTL)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maTL AS MA_THE_LOAI, tenTL AS TEN_THE_LOAI FROM TblTheLoai WHERE tenTL LIKE N'%{tenTL}%'";
            var dtTenTL = new DataTable();
            adt.SelectCommand = cmd;
            dtTenTL.Clear();
            adt.Fill(dtTenTL);
            Close_DB();
            return dtTenTL;
        }

        public DataTable showTL()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maTL AS MA_THE_LOAI, tenTL AS TEN_THE_LOAI FROM TblTheLoai";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            Close_DB();
            return dt;
        }
    }
}
