using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_QLNhanVien
    {
        DataTable ShowNV();
        bool addNV(DTO_QLNhanVien nv);
        bool editNV(DTO_QLNhanVien nv);
        bool deleteNV(DTO_QLNhanVien nv);
        DataTable searchMaNV(string maNV);
        DataTable searchTenNV(string tenNV);
    }
}
