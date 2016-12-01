using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebServiceDeserialization
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string EDPString = Request.QueryString["id"];
            Response.Write("EDP: "+EDPString + "</br>");
            string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=";
            URL += EDPString;
            URL += "&ignoreCatalog=true";
            XmlTextReader reader = new XmlTextReader(URL);
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            string valuetext = "";
            while (reader.ReadToFollowing("productService"))
            {
                while (reader.ReadToFollowing("getProductInfo"))
                {
                    while (reader.ReadToFollowing("result"))
                    {
                        while (reader.ReadToFollowing("item"))
                        {
                            while (reader.ReadToFollowing("productDetails"))
                            {
                                while (reader.Read())
                                {
                                    if (reader.Name == "name")
                                    {
                                        valuetext += "Name:";
                                        valuetext += reader.ReadElementString("name");
                                        valuetext += "</br></br>";
                                    }

                                    if (reader.Name == "description")
                                    {
                                        valuetext += "Desc:";
                                        valuetext += reader.ReadElementString("description");
                                        valuetext += "</br>";
                                    }

                                    if (reader.Name == "finalPrice")
                                    {
                                        valuetext += "Final Price:";
                                        valuetext += reader.ReadElementString("finalPrice");
                                        valuetext += "</br>";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Response.Write(valuetext);
            Response.Write("</br>");
        }
    }
}