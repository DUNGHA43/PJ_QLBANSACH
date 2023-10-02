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
    public class BLL_QLTL
    {
        DAL_QLTL qltl = new DAL_QLTL();
        public DataTable showTL()
        {
            return qltl.showTL();
        }
        public DataTable searchMaTL(string maTL)
        {
            return qltl.searchMaTL(maTL);
        }
        public DataTable searchTenTL(string tenTL)
        {
            return qltl.searchTenTL(tenTL);
        }
        public bool addTL(DTO_QLTL tl)
        {
            return qltl.addTL(tl);
        }
        public bool editTL(DTO_QLTL tl)
        {
            return qltl.editTL(tl);
        }
        public bool deleteTL(DTO_QLTL tl)
        {
            return qltl.deleteTL(tl);
        }
    }
}
