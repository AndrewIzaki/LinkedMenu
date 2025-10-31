using ingredient.Models;
namespace product.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}