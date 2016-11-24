using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SerializeAndDeserialize;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace SerializeAndDeserializeWeb
{
    public partial class ProductCRUD : System.Web.UI.Page
    {
        string message;
        int nodeCount = 0;
        public void AlertClear()
        {
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += Request.Url.AbsoluteUri;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void _btnSave_Click(object sender, EventArgs e)
        {
            string XmlFile = @"C:/Users/ccruz1/Documents/visual studio 2015/Projects/SerializeAndDeserialize/SerializeAndDeserializeWeb/ProductWEB.xml";
            if (!File.Exists(XmlFile))
            {
                //Serialize One Item only        
                Product product = new Product
                {
                    ID = _txtID.Text.Trim(),
                    Name = _txtName.Text.Trim(),
                    CategoryName = _txtCategory.Text.Trim(),
                    price = new Price { Value = Convert.ToInt32(_txtPrice.Text), Unit = _txtUnit.Text.Trim() },
                    description = new Description { Color = _txtColor.Text.Trim(), Size = _txtSize.Text.Trim(), Weight = _txtWeight.Text.Trim() }
                };
                XmlSerializer xmlserializer = new XmlSerializer(typeof(Product));
                string PathName = "C:/Users/ccruz1/Documents/visual studio 2015/Projects/SerializeAndDeserialize/SerializeAndDeserializeWeb/";
                StreamWriter SW = new StreamWriter(PathName + "ProductWEB.xml");
                xmlserializer.Serialize(SW, product);
                SW.Close();
                message = "Saved"; AlertClear();
                //End of Serialize One Item only
            }
            else
            {
                using (var reader = XmlReader.Create("C:/Users/ccruz1/Documents/visual studio 2015/Projects/SerializeAndDeserialize/SerializeAndDeserializeWeb/ProductWEB.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element &&
                            reader.Name == "name")
                        {
                            nodeCount++;
                        }
                    }
                }


            }
            message = "Saved! " + nodeCount +" Total Records" ; AlertClear();


            /*//List Serialize
            List<Product> ListProducts = new List<Product>();
            ListProducts.Add(new Product
            {
                ID = _txtID.Text.Trim(),
                Name = _txtName.Text.Trim(),
                CategoryName = _txtCategory.Text.Trim(),
                price = new Price { Value = Convert.ToInt32(_txtPrice.Text), Unit = _txtUnit.Text.Trim() },
                description = new Description { Color = _txtColor.Text.Trim(), Size = _txtSize.Text.Trim(), Weight = _txtWeight.Text.Trim() }
            });
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Product>));
            string PathName = "C:/Users/ccruz1/Documents/visual studio 2015/Projects/SerializeAndDeserialize/SerializeAndDeserializeWeb/";
            StreamWriter SW = new StreamWriter(PathName + "ProductWEB.xml");
            foreach (Product product in ListProducts)
            {
                xmlserializer.Serialize(SW, ListProducts);
            }
            SW.Close();*/
            //End of List Serizalize


            /*//Serialize One Item only        

             Product product = new Product
             {
                 ID = _txtID.Text.Trim(),
                 Name = _txtName.Text.Trim(),
                 CategoryName = _txtCategory.Text.Trim(),
                 price = new Price { Value = Convert.ToInt32(_txtPrice.Text), Unit = _txtUnit.Text.Trim() },
                 description = new Description { Color = _txtColor.Text.Trim(), Size = _txtSize.Text.Trim(), Weight = _txtWeight.Text.Trim() }
             };
             XmlSerializer xmlserializer = new XmlSerializer(typeof(Product));
             string PathName = "C:/Users/ccruz1/Documents/visual studio 2015/Projects/SerializeAndDeserialize/SerializeAndDeserializeWeb/";
             StreamWriter SW = new StreamWriter(PathName+"ProductWEB.xml");
             xmlserializer.Serialize(SW, product);
             SW.Close();
             ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Save');", true);

            //End of Serialize One Item only*/
        }
    }
}