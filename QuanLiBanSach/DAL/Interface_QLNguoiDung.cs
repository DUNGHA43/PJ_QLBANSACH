using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_QLNguoiDung
    {
        DataTable showUser();
        bool addUser(DTO_QLNguoiDung nd);
        bool editUser(DTO_QLNguoiDung nd);
        bool deleteUser(DTO_QLNguoiDung nd);
        DataTable loadTenNV();
        string loadMaNV(string tenNV);
    }
}
