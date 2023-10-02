using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_CTPhieuNhap
    {
        DataTable showSach(string maPN);
        DataTable showCTPN(string maPN);
        bool addS(DTO_CTPhieuNhap ctpn);
        bool editS(DTO_CTPhieuNhap ctpn, int slf);
        string getGiaNhap(int sl, string maS);
        bool deleteS(DTO_CTPhieuNhap ctpn);
        DataTable searchTenS(string maPN, string tenS);
        bool updateTongPN(DTO_CTPhieuNhap ctpn);
        bool updateTongPN(string maPN, int tmp);
    }
}
