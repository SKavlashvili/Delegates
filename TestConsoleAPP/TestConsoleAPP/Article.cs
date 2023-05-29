using System.Diagnostics;

namespace TestConsoleAPP
{
    public class Article
    {
        private string Name { get; set; }
        private decimal Price { get; set; }
        public string ShopName { private get; set; }
        public Article(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string GetName()
        {
            return this.Name;
        }
        public override string ToString()
        {
            return $"Name : {Name}\nPrice : {Price}\nShopName : {ShopName}";
        }
    }
}
