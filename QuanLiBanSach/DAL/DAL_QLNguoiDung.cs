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
    public class DAL_QLNguoiDung : Connect_Close_DB, Interface_QLNguoiDung
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DataTable showUser()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = @"SELECT * FROM TblTaiKhoan";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            Close_DB();
            return dt;
        }
        public bool addUser(DTO_QLNguoiDung nd)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblTaiKhoan VALUES ('{nd.iD}', N'{nd.pW}', N'{nd.chucVu}', '{nd.maNV}')";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;

        }
        public bool editUser(DTO_QLNguoiDung nd)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblTaiKhoan SET pw = N'{nd.pW}', chucVu = N'{nd.chucVu}', maNV = '{nd.maNV}' WHERE id = '{nd.iD}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }
        public bool deleteUser(DTO_QLNguoiDung nd)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblTaiKhoan WHERE id = '{nd.iD}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }
        public DataTable loadTenNV()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = @"SELECT tenNV FROM TblNhanVien";
            adt.SelectCommand = cmd;
            var dtTenNV = new DataTable();
            dtTenNV.Clear();
            adt.Fill(dtTenNV);
            Close_DB();
            return dtTenNV;
        }

        public string loadMaNV(string tenNV)
        {
            connect_DB();
            string tmp = "";
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maNV FROM TblNhanVien WHERE tenNV = N'{tenNV}'";
            var rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            Close_DB();
            return tmp;
        }
    }
}
