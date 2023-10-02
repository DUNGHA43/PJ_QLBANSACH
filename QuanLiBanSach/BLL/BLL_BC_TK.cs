using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_BC_TK
    {
        DAL_BC_TK bctk = new DAL_BC_TK();
        public DataTable showDSPN()
        {
            return bctk.showDSPN();
        }
        public DataTable showCTDSPN(string maPN)
        {
            return bctk.showCTDSPN(maPN);
        }
        public DataTable inPN(string thang, string nam, string nxb)
        {
            return bctk.inPN(thang, nam, nxb);
        }
        public DataTable inCTPN(string thang, string nam, string nxb)
        {
            return bctk.inCTPN(thang, nam, nxb);
        }
        public DataTable LoadTenNXB()
        {
            return bctk.LoadTenNXB();
        }

        public DataTable showDSHD()
        {
            return bctk.showDSHD();
        }
        public DataTable showCTDSHD(string maHD)
        {
            return bctk.showCTDSHD(maHD);
        }
        public DataTable inHD(string thang, string nam)
        {
            return bctk.inHD(thang, nam);
        }
        public DataTable inCTHD(string thang, string nam)
        {
            return bctk.inCTHD(thang, nam);
        }
    }
}
