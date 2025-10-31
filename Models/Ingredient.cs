using product.Models;

namespace ingredient.Models
{
    public class Ingredient
    {
        public int id { get; set; }
        public string name { get; set; }
        public float quantity { get; set; }
        public int ProductId { get; set; }

        public virtual product.Models.Product Product { get; set; }
    }
}