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
        }
    }
}
