using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_QLTG
    {
        DataTable showTG();
        DataTable searchMaTG(string maTG);
        DataTable searchTenTG(string tenTG);
        bool addTG(DTO_QLTG tg);
        bool editTG(DTO_QLTG tg);
        bool deleteTG(DTO_QLTG tg);
    }
}
