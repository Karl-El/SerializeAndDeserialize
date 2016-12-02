using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebServiceDeserialization
{
    public class ProdDetail
    {

        public void showDetails(string inputedp, string name, string description, string finalPrice, string xlg, string manufacturer, string availabilityDescription)
        {
            string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + inputedp + "&ignoreCatalog=true";
            XmlTextReader reader = new XmlTextReader(URL);
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.Read())
            {
                if (reader.Name == "name")
                {
                    name = reader.ReadElementString("name");
                }
                else { name = "empty"; }
                if (reader.Name == "description")
                {
                    description = reader.ReadElementString("description");
                }
                else { description = "empty"; }
                if (reader.Name == "finalPrice")
                {
                    finalPrice = reader.ReadElementString("finalPrice");
                }
                else { finalPrice = "empty"; }
                if (reader.Name == "xlg")
                {
                    xlg = reader.ReadElementString("xlg");
                }
                else { xlg = "empty"; }
                if (reader.Name == "manufacturer")
                {
                    manufacturer = reader.ReadElementString("manufacturer");
                }
                else { manufacturer = "empty"; }
                if (reader.Name == "availabilityDescription")
                {
                    availabilityDescription = reader.ReadElementString("availabilityDescription");
                }
                else { availabilityDescription = "empty"; }
            }
        }
    }

}

//Response.Write(valuetext);
//Response.Write("</br>");

//String inputurl = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + inputedp + "&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
//System.Xml.XmlTextReader reader = new XmlTextReader(inputurl);
//// reader.WhitespaceHandling = WhitespaceHandling.Significant;
//while (reader.Read())
//{
//    if (reader.Name == "store")
//    {
//        store = reader.ReadElementString("store");// show all EDP     
//    }
//    //============================
//    if (reader.Name == "name")
//    {
//        name = reader.ReadElementString("name");// show all EDP     
//    }
//    if (reader.Name == "description")
//    {
//        description = reader.ReadElementString("description");// show all EDP     
//    }
//    if (reader.Name == "finalPrice")
//    {
//        finalPrice = reader.ReadElementString("finalPrice");// show all EDP     
//    }
//    if (reader.Name == "xlg")  // IMAGE  & SIZE  // String value
//    {
//        xlg = reader.ReadElementString("xlg");// show all EDP      // IMAGE SOURCE
//    }
//    if (reader.Name == "manufacturer")
//    {
//        manufacturer = reader.ReadElementString("manufacturer");// show all EDP     
//    }
//    if (reader.Name == "availabilityDescription")
//    {
//        availabilityDescription = reader.ReadElementString("availabilityDescription");// show all EDP     
//    }

//    //reader.Name == "productDetails" ||reader.Name == "manufacturer"
//}

