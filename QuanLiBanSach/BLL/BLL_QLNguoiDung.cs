using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_QLNguoiDung
    {
        DAL_QLNguoiDung qlnd = new DAL_QLNguoiDung();

        public DataTable showUser()
        {
            return qlnd.showUser();
        }

        public bool addUser(DTO_QLNguoiDung nd)
        {
            return qlnd.addUser(nd);
        }

        public bool editUser(DTO_QLNguoiDung nd)
        {
            return qlnd.editUser(nd);
        }

        public bool deleteUser(DTO_QLNguoiDung nd)
        {
            return qlnd.deleteUser(nd);
        }

        public DataTable showTenNV()
        {
            return qlnd.loadTenNV();
        }

        public string loadMaNV(string tenNV)
        {
            return qlnd.loadMaNV(tenNV);
        }
    }
}
