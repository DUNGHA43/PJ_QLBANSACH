using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    interface Interface_QLTL
    {
        DataTable showTL();
        DataTable searchMaTL(string maTL);
        DataTable searchTenTL(string tenTL);
        bool addTL(DTO_QLTL tl);
        bool editTL(DTO_QLTL tl);
        bool deleteTL(DTO_QLTL tl);
    }
}
