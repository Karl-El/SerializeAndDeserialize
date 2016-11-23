using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SerializeAndDeserialize;
using System.Xml.Serialization;
using System.IO;

namespace SerializeAndDeserializeWeb
{
    public partial class ProductCRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void _btnSave_Click(object sender, EventArgs e)
        {

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
        }
    }
}