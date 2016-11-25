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
                List<product> ListProducts = new List<product>();
                ListProducts.Add(new product
                {
                    ID = "Prod ID 01",
                    Name = "Product Name 01",
                    CategoryName = "Category Name 01",
                    price = new Price { Value = 100, Unit = "USD" },
                    description = new Description { Color = "Red", Size = "Size 01", Weight = "100g" }
                });
                ListProducts.Add(new product
                {
                    ID = "Prod ID 02",
                    Name = "Product Name 02",
                    CategoryName = "Category Name 02",
                    price = new Price { Value = 100, Unit = "EUR" },
                    description = new Description { Color = "Blue", Size = "Size 02", Weight = "200g" }
                });
                ListProducts.Add(new product
                {
                    ID = "Prod ID 03",
                    Name = "Product Name 03",
                    CategoryName = "Category Name 03",
                    price = new Price { Value = 100, Unit = "PHP" },
                    description = new Description { Color = "Green", Size = "Size 03", Weight = "300g" }
                });
                XmlSerializer xmlserializer = new XmlSerializer(typeof(List<product>));
                StreamWriter SW = new StreamWriter("ListOfProduct.xml");
                xmlserializer.Serialize(SW, ListProducts);
                SW.Close();
                Console.WriteLine("Serialization Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //List Deserialize
            try
            {
                XmlSerializer xmlserializer = new XmlSerializer(typeof(List<product>));
                StreamReader SR = new StreamReader("ListOfProduct.xml");
                List<product> listproduct = (List<product>)xmlserializer.Deserialize(SR);
                Console.WriteLine("List Product Information");
                Console.WriteLine();
                foreach (product product in listproduct)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID        : " + product.ID);
                    Console.WriteLine("Name      : " + product.Name);
                    Console.WriteLine("Category  : " + product.CategoryName);
                    Console.WriteLine("Price     : " + product.price.Value);
                    Console.WriteLine("Unit      : " + product.price.Unit);
                    Console.WriteLine("Color     : " + product.description.Color);
                    Console.WriteLine("Size      : " + product.description.Size);
                    Console.WriteLine("Weight    : " + product.description.Weight);
                    Console.WriteLine();
                    Console.WriteLine("♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫♫");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            /*//Serialize
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
