using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    interface Interface_QLSach
    {
        DataTable showSach();
        bool addSach(DTO_QLSach s);
        bool editSach(DTO_QLSach s);
        bool deleteSach(DTO_QLSach s);
        DataTable loadTenTL();
        DataTable loadTenTG();
        DataTable loadTenNXB();
        string loadMaTL(string tenTL);
        string loadMaTG(string tenTG);
        string loadMaNXB(string tenNXB);
        DataTable searchSach(string maS, string tenS, string tl, string tg);
    }
}
