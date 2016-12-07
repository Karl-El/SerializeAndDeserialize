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
        public string AllProducts(List<string> ReadEDP)
        {
            string DetailString = "";
            #region Working Code for Prod details
            //------------------------------------------WORKING STATIC

           // List<string> ReadEDP;
            //ListEDP = EDPList.ListingEDP();
            for (int i = 0; i < ReadEDP.Count; i++)
            #region FORSTART
            {
                string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + ReadEDP[i] + "&ignoreCatalog=true";
                XmlTextReader reader = new XmlTextReader(URL);
                reader.WhitespaceHandling = WhitespaceHandling.Significant;
                DetailString += "<div class='row'><div class='col-sm-4'></div><div class='col-sm-4'><div class='panel panel-danger'><div class='panel-body'>";
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
                        DetailString += " class='img-responsive img-thumbnail center-block' width='150' height='150' alt='Image Not Available'>";
                        DetailString += "</br>";
                        DetailString += "</br>";
                    }
                }
                #endregion
                DetailString += "</div></div ></div ><div class='col-sm-4'></div></div>";
                DetailString += "</br>";
            }

            //------------------------------------------WORKING STATIC
            #endregion
            return (DetailString);
        }
    }

}


