using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_QLSach
    {
        DAL_QLSach qls = new DAL_QLSach();
        public DataTable showSach()
        {
            return qls.showSach();
        }
        public bool addSach(DTO_QLSach s)
        {
            return qls.addSach(s);
        }
        public bool editSach(DTO_QLSach s)
        {
            return qls.editSach(s);
        }
        public bool deleteSach(DTO_QLSach s)
        {
            return qls.deleteSach(s);
        }
        public DataTable loadTenTL()
        {
            return qls.loadTenTL();
        }
        public DataTable loadTenTG()
        {
            return qls.loadTenTG();
        }
        public DataTable loadTenNXB()
        {
            return qls.loadTenNXB();
        }
        public string loadMaTL(string tenTL)
        {
            return qls.loadMaTL(tenTL);
        }
        public string loadMaTG(string tenTG)
        {
            return qls.loadMaTG(tenTG);
        }
        public string loadMaNXB(string tenNXB)
        {
            return qls.loadMaNXB(tenNXB);
        }
        public DataTable searchSach(string maS, string tenS, string tl, string tg)
        {
            return qls.searchSach(maS, tenS, tl, tg);
        }
    }
}
