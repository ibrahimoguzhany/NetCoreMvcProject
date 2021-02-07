using cali.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cali.ViewComponents
{
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent // alternatif olarak Attribute yerine inherit de edebiliriz.
    {
        private readonly BlogDataContext db;
        public MonthlySpecialsViewComponent(BlogDataContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke()
        {
            var specials = db.MonthlySpecials.ToArray();
            return View(specials);
        }
    }
}
