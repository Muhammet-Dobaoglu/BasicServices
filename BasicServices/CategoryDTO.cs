using BasicServices.Models;

namespace BasicServices
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string ?Ad { get; set; }
        public string ?Aciklama { get; set; }
        public ICollection<Product> Urunler { get; set; }
    }
}
