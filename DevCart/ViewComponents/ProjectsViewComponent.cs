using DevCart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCart.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
            new Project(1,"تاکسی","درخواست تاکسی از اسنپ","project-1.jpg","sari"),
                   new Project(2,"غذا","درخواست آنلاین غذا ","project-2.jpg","food"),
                          new Project(3,"مدرسه","سیستم یکپارچه مدارس","project-3.jpg","shool"),
                                 new Project(4,"اتومبیل","درخواست خرید خودور ","project-4.jpg","car")
            };

            return View("_Projects", projects);
        }
    }
}
