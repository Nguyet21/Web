using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.Models;
namespace web.xuly
{
    public class NguoiDungDao
    {
        Yumdbcontext db = null;
        public string DANGNHAP;
        public NguoiDungDao()
        {
            db = new Yumdbcontext();
        }
        public int DangNhap(string DANGNHAP, string MATKHAU)
        {
            var nd = db.DANGNHAPs.Count(x => x.DANGNHAP1 == DANGNHAP && x.MATKHAU == MATKHAU);
            if (nd > 0)
                return 1;//Đăng nhập thành công
            else
                return 0;//Đăng nhập thất bại
        }

    }

}