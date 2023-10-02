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
    public class BLL_QLNXB
    {
        DAL_QLNXB qlnxb = new DAL_QLNXB();
        public bool addNXB(DTO_QLNXB nxb)
        {
            return qlnxb.addNXB(nxb);
        }
        public bool editNXB(DTO_QLNXB nxb)
        {
            return qlnxb.editNXB(nxb);
        }
        public bool deleteNXB(DTO_QLNXB nxb)
        {
            return qlnxb.deleteNXB(nxb);
        }
        public DataTable searchMaNXB(string maNXB)
        {
            return qlnxb.searchMaNXB(maNXB);
        }
        public DataTable searchTenNXB(string tenNXB)
        {
            return qlnxb.searchTenNXB(tenNXB);
        }
        public DataTable showNXB()
        {
            return qlnxb.showNXB();
        }
    }
}
