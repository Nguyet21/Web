using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;
using web.xuly;
namespace web.Areas.QuanTri.Controllers
{
    public class LoginController : Controller
    {
        // GET: QuanTri/Login      
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(DANGNHAP entity)
        {
            var dao = new NguoiDungDao();
            var model = dao.DangNhap(entity.DANGNHAP1, entity.MATKHAU);
            if (model == 1)
            {
                //Biến session là biến quản lý phiên làm việc của mỗi cá nhân
                Session["USER_NAME"] = entity.DANGNHAP1;

                return RedirectToAction("Index", "Default");
            }
            else
            {
                ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng");

            }
            return View();

        }
    }
}