using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_TaiKhoan : Connect_Close_DB, Interface_TaiKhoan
    {
        SqlCommand cmd;
        public string dangNhap(DTO_TaiKhoan tk)
        {
            connect_DB();
            string mk = null;
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT pw FROM TblTaiKhoan AS tk WHERE id = '{tk.tk}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                mk = rd.GetString(0);
            }
            rd.Close();
            Close_DB();
            return mk;
        }
        public bool doiMaKhau(DTO_TaiKhoan tk)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE TblTaiKhoan SET pw = '{tk.mk}' WHERE id = '{tk.tk}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            return false;
        }

        public string getCV(string id)
        {
            connect_DB();
            string tmp = null;
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT chucVu FROM TblTaiKhoan WHERE id = '{id}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            Close_DB();
            return tmp;
        }
    }
}
