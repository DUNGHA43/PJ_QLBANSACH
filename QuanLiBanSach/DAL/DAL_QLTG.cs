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
    public class DAL_QLTG : Connect_Close_DB, Interface_QLTG
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public bool addTG(DTO_QLTG tg)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblTacGia VALUES ('{tg.maTG}', N'{tg.tenTG}', N'{tg.diaChi}')";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool deleteTG(DTO_QLTG tg)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblTacGia WHERE maTG = '{tg.maTG}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool editTG(DTO_QLTG tg)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblTacGia SET tenTG = N'{tg.tenTG}', diaChi = N'{tg.diaChi}' WHERE maTG = '{tg.maTG}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public DataTable searchMaTG(string maTG)
        {
            connect_DB();
            var dtMaTG = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maTG AS MA_TAC_GIA, tenTG AS TEN_TAC_GIA, diaChi AS DIA_CHI FROM TblTacGia WHERE maTG LIKE '%{maTG}%'";
            adt.SelectCommand = cmd;
            dtMaTG .Clear();
            adt.Fill(dtMaTG );
            Close_DB();
            return dtMaTG;
        }

        public DataTable searchTenTG(string tenTG)
        {
            connect_DB();
            var dtTenTG = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maTG AS MA_TAC_GIA, tenTG AS TEN_TAC_GIA, diaChi AS DIA_CHI FROM TblTacGia WHERE tenTG LIKE N'%{tenTG}%'";
            adt.SelectCommand = cmd;
            dtTenTG.Clear();
            adt.Fill(dtTenTG);
            Close_DB();
            return dtTenTG;
        }

        public DataTable showTG()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maTG AS MA_TAC_GIA, tenTG AS TEN_TAC_GIA, diaChi AS DIA_CHI FROM TblTacGia";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            Close_DB();
            return dt;
        }
    }
}
