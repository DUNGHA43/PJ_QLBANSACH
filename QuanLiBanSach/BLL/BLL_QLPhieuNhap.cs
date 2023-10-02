using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_QLPhieuNhap
    {
        DAL_QLPhieuNhap qlpn = new DAL_QLPhieuNhap();
        public DataTable showPN()
        {
            return qlpn.showPN();
        }
        public bool addPN(DTO_QLPhieuNhap pn)
        {
            return qlpn.addPN(pn);
        }
        public bool editPN(DTO_QLPhieuNhap pn)
        {
            return qlpn.editPN(pn);
        }
        public bool deletePN(DTO_QLPhieuNhap pn)
        {
            return qlpn.deletePN(pn);
        }
        public DataTable searchPN(string maPN)
        {
            return qlpn.searchPN(maPN);
        }
        public DataTable loadTenNXB()
        {
            return qlpn.loadTenNXB();
        }
        public String getMaNXB(string tenNXB)
        {
            return qlpn.getMaNXB(tenNXB);
        }
        public String getMaNV(string tk)
        {
            return qlpn.getMaNV(tk);
        }
    }
}
