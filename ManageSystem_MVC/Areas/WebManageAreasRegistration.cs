using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageSystem_MVC.Areas
{
    public class WebManageAreasRegistration : AreaRegistration
    {
        public override string AreaName 
        {
            get
            {
                return "Web_Manage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Web_Manage",
                "Web_Manage/{controller}/{action}/{id}",
                new { controller="Home",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}