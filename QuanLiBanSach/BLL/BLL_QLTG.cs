using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_QLTG
    {
        DAL_QLTG qltg = new DAL_QLTG();
        public DataTable showTG()
        {
            return qltg.showTG();
        }
        public DataTable searchMaTG(string maTG)
        {
            return qltg.searchMaTG(maTG);
        }
        public DataTable searchTenTG(string tenTG)
        {
            return qltg.searchTenTG(tenTG);
        }
        public bool addTG(DTO_QLTG tg)
        {
            return qltg.addTG(tg);
        }
        public bool editTG(DTO_QLTG tg)
        {
            return qltg.editTG(tg);
        }
        public bool deleteTG(DTO_QLTG tg)
        {
            return qltg.deleteTG(tg);
        }
    }
}
