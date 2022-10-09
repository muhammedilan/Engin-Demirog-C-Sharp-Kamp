namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductPrice = 40;
            product1.ProductName = "Fare";

            Product product2 = new Product();
            product2.ProductPrice = 150;
            product2.ProductName = "Klavye";

            Product[] product = new Product[] { product1,product2 };
            for(int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i].ProductName+" " + product[i].ProductPrice);
            }

            foreach(var item in product)
            {
                Console.WriteLine(item.ProductName + " " + item.ProductPrice);
            }
            var j = 0;
            Console.WriteLine(product.Length);
            while(j < product.Length)
            {
                Console.WriteLine(product[j].ProductName + " " + product[j].ProductPrice);
                j++;
            }
        }
        
    }

    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}