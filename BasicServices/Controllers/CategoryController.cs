using BasicServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicServices.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext _db;
        public CategoryController(NorthwindContext db)
        {
            _db = db;
        }

        public IActionResult List()
        {
            var clist = _db.Set<Category>().ToList().Select(x => new CategoryDTO
            {

                Aciklama = x.Description,
                Ad = x.CategoryName,
                Id=x.CategoryId,
                Urunler=x.Products
            });

        
            return (Json(clist));
        }
        public JsonResult Find(int id)
        {
            //tek bir categori buluyor
            // oyüzden tipi 
            var cat = _db.Set<Category>().Find(id);
            var catDto = new CategoryDTO();
            catDto.Aciklama = cat.Description;
            catDto.Id = cat.CategoryId;
            catDto.Ad = cat.CategoryName;
            catDto.Urunler=cat.Products;

            return (Json(catDto));
        }
    }
}
