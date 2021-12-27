using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace json_работа_с_фалом
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("D:/Итмо проекты/json/json/bin/Debug/Product.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            Product maxProduct = products[0];
            foreach (Product e in products)
            {
                if (e.ProductPrice > maxProduct.ProductPrice)
                {
                    maxProduct = e;
                }
            }
                Console.WriteLine($"{maxProduct.ProductCode} \n {maxProduct.ProductName} \n {maxProduct.ProductPrice}");
                Console.ReadKey();
            


        }
    }
}
