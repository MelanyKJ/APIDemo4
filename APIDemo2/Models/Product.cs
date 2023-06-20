using NuGet.Protocol.Core.Types;

namespace APIDemo2.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public int CategoryID { get; set; }
        public Category? Category { get; set; }

    }
}
