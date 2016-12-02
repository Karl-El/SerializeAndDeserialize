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
            string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist="+ EDPString + "&ignoreCatalog=true";
            XmlTextReader reader = new XmlTextReader(URL);
            //reader.WhitespaceHandling = WhitespaceHandling.Significant;
            string DetailString = "";
            #region WHILES
            //while (reader.ReadToFollowing("productService"))
            //{
            //    while (reader.ReadToFollowing("getProductInfo"))
            //    {
            //        while (reader.ReadToFollowing("result"))
            //        {

            //            while (reader.ReadToFollowing("item"))
            //            {

            //                while (reader.ReadToFollowing("productDetails"))
            //                #region productDetailsNODE
            //                {

            //                }
            //                #endregion
            //                //while (reader.ReadToFollowing("prices"))
            //                //#region pricesNODE
            //                //{
            //                //    if (reader.Name == "finalPrice")
            //                //    {
            //                //        DetailString += "Final Price: ";
            //                //        DetailString += reader.ReadElementString("finalPrice");
            //                //        DetailString += "</br>";
            //                //    }
            //                //}
            //                //#endregion
            //            }
            //        }
            //    }
            //}
            #endregion

            while (reader.Read())
            {
                if (reader.Name == "name")
                {
                    DetailString += "Name: ";
                    DetailString += reader.ReadElementString("name");
                    DetailString += "</br>";
                }
                if (reader.Name == "manufacturer")
                {
                    DetailString += "Manufacturer: ";
                    DetailString += reader.ReadElementString("manufacturer");
                    DetailString += "</br>";
                }
                if (reader.Name == "description")
                {
                    DetailString += "Description: ";
                    DetailString += reader.ReadElementString("description");
                    DetailString += "</br>";
                }
                if (reader.Name == "finalPrice")
                {
                    DetailString += "Final Price: ";
                    DetailString += reader.ReadElementString("finalPrice");
                    DetailString += "</br>";
                }
                if (reader.Name == "store")
                {
                    DetailString += "Store: ";
                    DetailString += reader.ReadElementString("store");
                    DetailString += "</br>";
                }
                if (reader.Name == "availabilityDescription")
                {
                    DetailString += "Availabilty: ";
                    DetailString += reader.ReadElementString("availabilityDescription");
                    DetailString += "</br>";
                }
                if (reader.Name == "xlg")
                {
                    DetailString += "Image URL: ";
                    DetailString += reader.ReadElementString("xlg");
                    DetailString += "</br>";
                }
            }
            Response.Write(DetailString);
            Response.Write("</br>");
        }
    }
}