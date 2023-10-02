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
    public class BLL_CTHoaDon
    {
        DAL_CTHoaDon qlcthd = new DAL_CTHoaDon();
        public DataTable showSach()
        {
            return qlcthd.showSach();
        }
        public DataTable showCTHD(string maHD)
        {
            return qlcthd.showCTHD(maHD);
        }
        public bool addS(DTO_CTHoaDon cthd)
        {
            return qlcthd.addS(cthd);
        }
        public bool deleteS(DTO_CTHoaDon cthd)
        {
            return qlcthd.deleteS(cthd);
        }
        public string getGiaBan(int sl, string maS)
        {
            return qlcthd.getGiaBan(sl, maS);
        }
        public DataTable searchTenS(string tenS)
        {
            return qlcthd.searchTenS(tenS);
        }
        public bool updateTongHD(DTO_CTHoaDon cthd)
        {
            return qlcthd.updateTongHD(cthd);
        }
        public bool updateTongHD(string maHD, int tmp)
        {
            return qlcthd.updateTongHD(maHD, tmp);
        }
    }
}
