using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_QLNhanVien
    {
        DAL_QLNhanVien qlnv = new DAL_QLNhanVien();

        public DataTable showNV()
        {
            return qlnv.ShowNV();
        }
        public DataTable searchMaNV(string maNV)
        {
            return qlnv.searchMaNV(maNV);
        }
        public DataTable searchTenNV(string tenNV)
        {
            return qlnv.searchTenNV(tenNV);
        }
        public bool addNV(DTO_QLNhanVien nv)
        {
            return qlnv.addNV(nv);
        }
        public bool editNV(DTO_QLNhanVien nv)
        {
            return qlnv.editNV(nv);
        }
        public bool deleteNV(DTO_QLNhanVien nv)
        {
            return qlnv.deleteNV(nv);
        }
    }
}
