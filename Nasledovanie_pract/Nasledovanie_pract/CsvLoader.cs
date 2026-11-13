using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie_pract
{
    public class CsvLoader
    {
        public static List<Product> LoadProducts(string filePath)
        {
            List<Product> loadedProducts = new List<Product>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден: " + filePath);
                return loadedProducts;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(';');

                if (parts.Length == 4)
                {
                    string name = parts[0].Trim(); 
                    int count = int.Parse(parts[1].Trim());
                    int price = int.Parse(parts[2].Trim()); 
                    string type = parts[3].Trim();

                    Product product = null;

                    if (type.Equals("Food", StringComparison.OrdinalIgnoreCase))
                    {
                        product = new Food();
                    }
                    else if (type.Equals("Drinks", StringComparison.OrdinalIgnoreCase))
                    {
                        product = new Drinks();
                    }
                    else
                    {
                        product = new Product();
                    }

                    product.SetName(name);
                    product.SetCount(count);
                    product.SetPrice(price);

                    loadedProducts.Add(product);
                }
            }

            return loadedProducts;
        }
    }
}
    
