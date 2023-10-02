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
    public class BLL_QLBanSach
    {
        DAL_QLBanSach qlhd = new DAL_QLBanSach();
        public bool addHD(DTO_QLBanSach hd)
        {
            return qlhd.addHD(hd);
        }
        public bool editHD(DTO_QLBanSach hd)
        {
            return qlhd.editHD(hd);
        }
        public bool deleteHD(DTO_QLBanSach hd)
        {
            return qlhd.deleteHD(hd);
        }

        public string getMaNV(string tk)
        {
            return qlhd.getMaNV(tk);
        }

        public DataTable searchHD(string maHD)
        {
            return qlhd.searchHD(maHD);
        }

        public DataTable showHD()
        {
            return qlhd.showHD();
        }

        public DataTable inHD(DTO_QLBanSach hd)
        {
            return qlhd.inHD(hd);
        }
    }
}
