using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    interface Interface_QLPhieuNhap
    {
        DataTable showPN();
        bool addPN(DTO_QLPhieuNhap pn);
        bool editPN(DTO_QLPhieuNhap pn);
        bool deletePN(DTO_QLPhieuNhap pn);
        DataTable searchPN(string maPN);
        DataTable loadTenNXB();
        String getMaNXB(string tenNXB);
        String getMaNV(string tk);

    }
}
