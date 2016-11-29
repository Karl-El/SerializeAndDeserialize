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
            Response.Write(EDPString + "</br>");
            string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=";
            URL += EDPString;
            URL += "&ignoreCatalog=true";
            Response.Write(URL);
            XmlTextReader reader = new XmlTextReader(URL);
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.ReadToFollowing("result"))
            {
                while (reader.ReadToFollowing("productDetails"))
                {
                    string valuetext = reader.Value;

                    Response.Write("Value:" + valuetext);
                    Response.Write("</br>");

                    //Response.Write("Attribute Name: " + attr);
                    //Response.Write("</br>");
                }
            }
        }
    }
}