using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public interface Interface_TaiKhoan
    {
        string dangNhap(DTO_TaiKhoan tk);
        bool doiMaKhau(DTO_TaiKhoan tk);
        string getCV(string id);
    }
}
