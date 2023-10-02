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
    public class DAL_QLNhanVien : Connect_Close_DB, Interface_QLNhanVien
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public bool addNV(DTO_QLNhanVien nv)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"INSERT INTO TblNhanVien VALUES ('{nv.maNV}', N'{nv.tenNV}', '{nv.ngaySinh}', '{nv.cccd}', '{nv.soDT}', N'{nv.diaChi}', N'{nv.lichLam}')";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool deleteNV(DTO_QLNhanVien nv)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"DELETE TblNhanVien WHERE maNV = '{nv.maNV}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public bool editNV(DTO_QLNhanVien nv)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"UPDATE TblNhanVien SET tenNV = N'{nv.tenNV}', ngaySinh = '{nv.ngaySinh}', cCCD = '{nv.cccd}', soDT = '{nv.soDT}', diaChi = N'{nv.diaChi}', lichLam = N'{nv.lichLam}' WHERE maNV = '{nv.maNV}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                Close_DB();
                return true;
            }
            Close_DB();
            return false;
        }

        public DataTable searchMaNV(string maNV)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT * FROM TblNhanVien WHERE maNV LIKE '%{maNV}%' AND (maNV LIKE '%QL%' OR maNV LIKE '%NV%')";
            adt.SelectCommand = cmd;
            var dtMaNV = new DataTable();
            dtMaNV.Clear();
            adt.Fill(dtMaNV);
            Close_DB();
            return dtMaNV;
        }

        public DataTable searchTenNV(string tenNV)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT * FROM TblNhanVien WHERE tenNV LIKE N'%{tenNV}%' AND (maNV LIKE '%QL%' OR maNV LIKE '%NV%')";
            adt.SelectCommand = cmd;
            var dtTenNV = new DataTable();
            dtTenNV.Clear();
            adt.Fill(dtTenNV);
            Close_DB();
            return dtTenNV;
        }

        public DataTable ShowNV()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT * FROM TblNhanVien WHERE maNV LIKE '%QL%' OR maNV LIKE '%NV%'";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            Close_DB();
            return dt;
        }
    }
}
