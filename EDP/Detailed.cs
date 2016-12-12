using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace EDP
{
    public class Detailed
    {
        public string ShowDetails(List<string> GetEDP)
        {
            string DetailString = "";
            #region Working Code for Prod details
            //------------------------------------------WORKING STATIC

            // List<string> GetEDP;
            //ListEDP = EDPList.ListingEDP();
            for (int i = 0; i < GetEDP.Count; i++)
            #region FORSTART
            {
                string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + GetEDP[i] + "&ignoreCatalog=true";
                XmlTextReader reader = new XmlTextReader(URL);
                reader.WhitespaceHandling = WhitespaceHandling.Significant;
                DetailString += "<div class='card card-outline-info'><div class='card-block'>";
                while (reader.Read())
                {

                    if (reader.Name == "name")
                    {
                        DetailString += "Name: ";
                        DetailString += reader.ReadElementString("name");
                        DetailString += "</br>";
                        DetailString += "</br>";
                    }
                    if (reader.Name == "manufacturer")
                    {
                        DetailString += "Manufacturer: ";
                        DetailString += reader.ReadElementString("manufacturer");
                        DetailString += "</br>";
                        DetailString += "</br>";
                    }
                    if (reader.Name == "description")
                    {
                        DetailString += "Description: ";
                        DetailString += reader.ReadElementString("description");
                        DetailString += "</br>";
                        DetailString += "</br>";
                    }
                    if (reader.Name == "finalPrice")
                    {
                        DetailString += "Final Price: ";
                        DetailString += reader.ReadElementString("finalPrice");
                        DetailString += "</br>";
                        DetailString += "</br>";
                    }
                    //if (reader.Name == "store")
                    //{
                    //    DetailString += "Store: ";
                    //    DetailString += reader.ReadElementString("store");
                    //    DetailString += "</br>";
                    //}
                    if (reader.Name == "availabilityDescription")
                    {
                        DetailString += "Availabilty: ";
                        DetailString += reader.ReadElementString("availabilityDescription");
                        DetailString += "</br>";
                        DetailString += "</br>";
                    }
                    if (reader.Name == "xlg")
                    {
                        string ImageURL = reader.ReadElementString("xlg");
                        DetailString += "Image URL: ";
                        DetailString += ImageURL + "</br>";
                        DetailString += "<img src =";
                        DetailString += '"' + ImageURL + '"';
                        DetailString += " class='img-responsive img-thumbnail center-block' width='150' height='150' onerror='this.src = 'http://www.pcm.com/mall/widgetti/images/shared/noImageMed.jpg';'>";
                        //DetailString += "<asp:Image ID ='_imgProd' runat = 'server' AlternateText = 'No Image' ImageUrl = ";
                        //DetailString += '"' + ImageURL + '"';
                        //DetailString += "/>";

                    }
                }
                #endregion
                DetailString += "</div></div >";
            }

            //------------------------------------------WORKING STATIC
            #endregion
            return (DetailString);
        }
    }

}
