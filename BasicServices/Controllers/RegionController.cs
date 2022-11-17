using BasicServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicServices.Controllers
{
    public class RegionController : Controller
    {
        NorthwindContext _db;
        public RegionController(NorthwindContext db)
        {
            _db = db;
        }

        public IActionResult List()
        {
            //wiewe gerek yok
            //sadece gösteriyor
            //güzel göstermek için arayüz yazılmalı.
            //Include(x=>x.Territories)
            var listele = _db.Set<Region>().ToList();
            return (Json(listele));
        }
    }
}
