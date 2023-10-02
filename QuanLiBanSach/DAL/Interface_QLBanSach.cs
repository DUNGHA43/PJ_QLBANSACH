using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    interface Interface_QLBanSach
    {
        DataTable showHD();
        bool addHD(DTO_QLBanSach hd);
        bool editHD(DTO_QLBanSach hd);
        bool deleteHD(DTO_QLBanSach hd);
        DataTable searchHD(string maHD);
        string getMaNV(string tk);
        DataTable inHD(DTO_QLBanSach hd);
    }
}
