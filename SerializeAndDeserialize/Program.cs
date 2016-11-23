using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializeAndDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //List Serialize
            try
            {
                List<Product> ListProducts = new List<Product>();
                ListProducts.Add(new Product
                {
                    ID = "Prod ID 01",
                    Name = "Product Name 01",
                    CategoryName = "Category Name 01",
                    price = new Price { Value = 100, Unit = "USD" },
                    description = new Description { Color = "red", Size = "Size 01", Weight = "100g" }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            /*
            //Serialize
            try
            {
                Product product = new Product
                {
                    ID = "Prod ID 01",
                    Name = "Product Name 01",
                    CategoryName = "Category Name 01",
                    price = new Price { Value = 100, Unit = "USD" },
                    description = new Description { Color = "red", Size = "Size 01", Weight = "100g" }
                };
                XmlSerializer xmlserializer = new XmlSerializer(typeof(Product));
                StreamWriter SW = new StreamWriter("Product.xml");
                xmlserializer.Serialize(SW, product);
                SW.Close();
                Console.WriteLine("Serialization Success");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

            //Deserialize
            try
            {
                XmlSerializer xmlserializer = new XmlSerializer(typeof(Product));
                StreamReader SR = new StreamReader("Product.xml");
                Product product = (Product)xmlserializer.Deserialize(SR);
                Console.WriteLine("Product Information");
                Console.WriteLine("ID     : "+ product.ID);
                Console.WriteLine("Name   : "+ product.Name);
                Console.WriteLine("Price  : "+ product.price.Value);
                Console.WriteLine("Unit   : "+ product.price.Unit);
                Console.WriteLine("Color  : "+ product.description.Color);
                Console.WriteLine("Size   : "+ product.description.Size);
                Console.WriteLine("Weight : "+ product.description.Weight);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            Console.ReadLine();
        }
    }
}
