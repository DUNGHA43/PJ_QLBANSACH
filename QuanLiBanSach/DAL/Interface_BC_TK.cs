using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    interface Interface_BC_TK
    {
        DataTable showDSPN();
        DataTable showCTDSPN(string maPN);
        DataTable inPN(string thang, string nam, string nxb);
        DataTable inCTPN(string thang, string nam, string nxb);
        DataTable LoadTenNXB();

        DataTable showDSHD();
        DataTable showCTDSHD(string maPN);
        DataTable inHD(string thang, string nam);
        DataTable inCTHD(string thang, string nam);
    }
}
