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
    public class BLL_CTPhieuNhap
    {
        DAL_CTPhieuNhap qlctpn = new DAL_CTPhieuNhap();
        public DataTable showCTPN(string maPN)
        {
            return qlctpn.showCTPN(maPN);
        }

        public DataTable showSach(string maNXB)
        {
            return qlctpn.showSach(maNXB);
        }
        public string getGiaNhap(int sl, string maS)
        {
            return qlctpn.getGiaNhap(sl, maS);
        }
        public bool addS(DTO_CTPhieuNhap ctpn)
        {
            return qlctpn.addS(ctpn);
        }
        public bool editS(DTO_CTPhieuNhap ctpn, int slf)
        {
            return qlctpn.editS(ctpn, slf);
        }
        public bool deleteS(DTO_CTPhieuNhap ctpn)
        {
            return qlctpn.deleteS(ctpn);
        }

        public DataTable searchTenS(string maPN, string tenS)
        {
            return qlctpn.searchTenS(maPN, tenS);
        }
        public bool updateTongPN(DTO_CTPhieuNhap ctpn)
        {
            return qlctpn.updateTongPN(ctpn);
        }
        public bool updateTongPN(string maPN, int tmp)
        {
            return qlctpn.updateTongPN(maPN, tmp);
        }
    }
}
