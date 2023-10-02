using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_QLNXB
    {
        DataTable showNXB();
        DataTable searchMaNXB(string maNXB);
        DataTable searchTenNXB(string tenNXB);
        bool addNXB(DTO_QLNXB nxb);
        bool editNXB(DTO_QLNXB nxb);
        bool deleteNXB(DTO_QLNXB nxb);
    }
}
