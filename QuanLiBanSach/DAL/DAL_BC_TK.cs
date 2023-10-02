using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL_BC_TK : Connect_Close_DB, Interface_BC_TK
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dtshowPN = new DataTable();
        DataTable dtshowCTPN = new DataTable();
        DataTable dtInPN = new DataTable();
        DataTable dtInCTPN = new DataTable();
        DataTable dtshowHD = new DataTable();
        DataTable dtshowCTHD = new DataTable();
        DataTable dtInHD = new DataTable();
        DataTable dtInCTHD = new DataTable();
        public DataTable inCTPN(string thang, string nam, string nxb)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT TblPhieuNhap.maPN, TblSach.tenSach, TblPhieuNhap.ngayNhap, TblCTPhieuNhap.soLuongNhap, TblSach.giaNhap, TblCTPhieuNhap.giaNhap AS Expr1, TblNhaXuatBan.tenNXB
                                FROM TblCTPhieuNhap INNER JOIN TblSach ON TblSach.maSach = TblCTPhieuNhap.maSach 
                                INNER JOIN TblPhieuNhap ON TblPhieuNhap.maPN = TblCTPhieuNhap.maPN 
                                INNER JOIN TblNhaXuatBan ON TblNhaXuatBan.maNXB = TblSach.maNXB AND TblNhaXuatBan.maNXB = TblPhieuNhap.maNXB
                                WHERE MONTH(ngayNhap) LIKE '%{thang}%' AND YEAR(ngayNhap) LIKE '%{nam}%' AND tenNXB LIKE '%{nxb}%'";
            adt.SelectCommand = cmd;
            dtInCTPN.Clear();
            adt.Fill(dtInCTPN);
            Close_DB();
            return dtInCTPN;
        }

        public DataTable inPN(string thang, string nam, string nxb)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maPN, ngayNhap, tenNXB, tenNV, tongTien FROM TblPhieuNhap
                                INNER JOIN TblNhaXuatBan
                                ON TblNhaXuatBan.maNXB = TblPhieuNhap.maNXB
                                INNER JOIN TblNhanVien
                                ON TblNhanVien.maNV = TblPhieuNhap.maNV
                                WHERE MONTH(ngayNhap) LIKE '%{thang}%' AND YEAR(ngayNhap) LIKE '%{nam}%' AND tenNXB LIKE '%{nxb}%'";
            adt.SelectCommand = cmd;
            dtInPN.Clear();
            adt.Fill(dtInPN);
            Close_DB();
            return dtInPN;
        }

        public DataTable showDSPN()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maPN AS MÃ_PHIẾU_NHẬP, ngayNhap AS NGÀY_NHẬP, tenNXB AS TÊN_NHÀ_XUẤT_BẢN, tenNV AS NGƯỜI_LẬP_PHIẾU, tongTien AS TỔNG_TIỀN FROM TblPhieuNhap
                                INNER JOIN TblNhaXuatBan
                                ON TblNhaXuatBan.maNXB = TblPhieuNhap.maNXB
                                INNER JOIN TblNhanVien
                                ON TblNhanVien.maNV = TblPhieuNhap.maNV";
            adt.SelectCommand = cmd;
            dtshowPN.Clear();
            adt.Fill(dtshowPN);
            Close_DB();
            return dtshowPN;
        }
        public DataTable showCTDSPN(string maPN)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT tenSach AS TÊN_SÁCH, soLuongNhap AS SỐ_LƯỢNG, TblSach.giaNhap AS GIÁ_NHẬP, TblCTPhieuNhap.giaNhap AS THÀNH_TIỀN FROM TblCTPhieuNhap
                                INNER JOIN TblSach ON TblSach.maSach = TblCTPhieuNhap.maSach
                                WHERE maPN = '{maPN}'";
            adt.SelectCommand = cmd;
            dtshowCTPN.Clear();
            adt.Fill(dtshowCTPN);
            Close_DB();
            return dtshowCTPN;
        }

        public DataTable LoadTenNXB()
        {
            var nxb = new DataTable();
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT tenNXB FROM TblNhaXuatBan";
            adt.SelectCommand = cmd;
            nxb.Clear();
            adt.Fill(nxb);
            Close_DB();
            return nxb;
        }


        public DataTable showDSHD()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maHD AS MÃ_HÓA_ĐƠN, ngayBan as NGÀY_BÁN, tenNV AS NHÂN_VIÊN_LẬP, tongTien AS TỔNG_TIỀN FROM TblHoaDon
                                 INNER JOIN TblNhanVien ON TblNhanVien.maNV = TblHoaDon.maNV";
            adt.SelectCommand = cmd;
            dtshowHD.Clear();
            adt.Fill(dtshowHD);
            Close_DB();
            return dtshowHD;
        }
        public DataTable showCTDSHD(string maHD)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT TblHoaDon.maHD AS MÃ_HÓA_ĐƠN, tenSach AS TÊN_SÁCH, SUM(soLuong) AS SỐ_LƯỢNG, giaBan AS GIÁ_BÁN, SUM(thanhTien) AS THÀNH_TIỀN FROM TblCTHoaDon
                                INNER JOIN TblSach ON TblSach.maSach = TblCTHoaDon.maSach
                                INNER JOIN TblHoaDon ON TblHoaDon.maHD = TblCTHoaDon.maHD
                                WHERE TblHoaDon.maHD = '{maHD}'
                                GROUP BY TblHoaDon.maHD, tenSach, giaBan";
            adt.SelectCommand = cmd;
            dtshowCTHD.Clear();
            adt.Fill(dtshowCTHD);
            Close_DB();
            return dtshowCTHD;
        }
        public DataTable inHD(string thang, string nam)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT maHD AS MÃ_HÓA_ĐƠN, ngayBan as NGÀY_BÁN, tenNV AS NHÂN_VIÊN_LẬP, tongTien AS TỔNG_TIỀN FROM TblHoaDon
                                    INNER JOIN TblNhanVien ON TblNhanVien.maNV = TblHoaDon.maNV
                                    WHERE MONTH(ngayBan) LIKE '%{thang}%' AND YEAR(ngayBan) LIKE '%{nam}%'";
            adt.SelectCommand = cmd;
            dtInHD.Clear();
            adt.Fill(dtInHD);
            Close_DB();
            return dtInHD;
        }
        public DataTable inCTHD(string thang, string nam)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT TblHoaDon.maHD, tenSach AS TÊN_SÁCH, SUM(soLuong) AS SỐ_LƯỢNG, giaBan AS GIÁ_BÁN, SUM(thanhTien) AS THÀNH_TIỀN FROM TblCTHoaDon
                                INNER JOIN TblSach ON TblSach.maSach = TblCTHoaDon.maSach
                                INNER JOIN TblHoaDon ON TblHoaDon.maHD = TblCTHoaDon.maHD
                                WHERE MONTH(ngayBan) LIKE '%{thang}%' AND YEAR(ngayBan) LIKE '%{nam}%'
                                GROUP BY TblHoaDon.maHD, tenSach, giaBan";
            adt.SelectCommand = cmd;
            dtInCTHD.Clear();
            adt.Fill(dtInCTHD);
            Close_DB();
            return dtInCTHD;
        }
    }
}
