using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoan _TK = new DAL_TaiKhoan();

        // trả về mật khẩu của tài khoản truy vấn để so sánh với mật khẩu người dùng nhập
        public string DangNhap(DTO_TaiKhoan dn)
        {
            return _TK.dangNhap(dn);
        }
        // Đổi mật khẩu
        public bool DoiMatKhau(DTO_TaiKhoan dn)
        {
            return _TK.doiMaKhau(dn);
        }

        public string getCV(string id)
        {
            return _TK.getCV(id);
        }
    }
}
