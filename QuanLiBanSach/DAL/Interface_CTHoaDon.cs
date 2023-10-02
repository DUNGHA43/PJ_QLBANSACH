using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_CTHoaDon
    {
        DataTable showSach();
        DataTable showCTHD(string maHD);
        bool addS(DTO_CTHoaDon cthd);
        bool deleteS(DTO_CTHoaDon cthd);
        string getGiaBan(int sl, string maS);
        DataTable searchTenS(string tenS);
        bool updateTongHD(DTO_CTHoaDon cthd);
        bool updateTongHD(string maHD, int tmp);
    }
}
