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
            Response.Write("EDP: " + EDPString + "</br>");
            string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=";
            URL += EDPString;
            URL += "&ignoreCatalog=true";
            XmlTextReader reader = new XmlTextReader(URL);
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            string DetailString = "";
            while (reader.ReadToFollowing("productService"))
            {
                while (reader.ReadToFollowing("getProductInfo"))
                {
                    while (reader.ReadToFollowing("result"))
                    {

                        while (reader.ReadToFollowing("item"))
                        {

                            while (reader.ReadToFollowing("productDetails"))
                            #region
                            {
                                while (reader.Read())
                                {
                                    if (reader.Name == "name")
                                    {
                                        DetailString += "Name:";
                                        DetailString += reader.ReadElementString("name");
                                        DetailString += "</br>";
                                    }
                                    if (reader.Name == "manufacturer")
                                    {
                                        DetailString += "Manufacturer:";
                                        DetailString += reader.ReadElementString("manufacturer");
                                        DetailString += "</br>";
                                    }
                                    if (reader.Name == "description")
                                    {
                                        DetailString += "Desc:";
                                        DetailString += reader.ReadElementString("description");
                                        DetailString += "</br>";
                                    }
                                    //if (reader.Name == "store")
                                    //{
                                    //    valuetext += "Store:";
                                    //    valuetext += reader.ReadElementString("store");
                                    //    valuetext += "</br>";
                                    //}
                                    //if (reader.Name == "availabilityDescription")
                                    //{
                                    //    valuetext += "Availabilty:";
                                    //    valuetext += reader.ReadElementString("availabilityDescription");
                                    //    valuetext += "</br>";
                                    //}
                                    //if (reader.Name == "xlg")
                                    //{
                                    //    valuetext += "Image URL:";
                                    //    valuetext += reader.ReadElementString("xlg");
                                    //    valuetext += "</br>";
                                    //}
                                }
                            }
                            #endregion

                            while (reader.ReadToFollowing("prices"))
                            #region
                            {
                                if (reader.Name == "finalPrice")
                                {
                                    DetailString += "Final Price:";
                                    DetailString += reader.ReadElementString("finalPrice");
                                    DetailString += "</br>";
                                }
                            }
                            #endregion
                        }
                    }
                }
            }

            Response.Write(DetailString);
            Response.Write("</br>");
        }
    }
}