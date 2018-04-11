using System.Web.Mvc;

namespace web.Areas.QuanTri
{
    public class QuanTriAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "QuanTri";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "QuanTri_default",
                "QuanTri/{controller}/{action}/{id}",
                new { action = "TrangChuQT", id = UrlParameter.Optional }
            );
        }
    }
}