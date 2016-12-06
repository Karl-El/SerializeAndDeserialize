using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WebServiceDeserialization
{
    public class Manufacturer
    {
        EDPList EDPList = new EDPList();
        List<string> ListEDP;
        public List<string> ListManufacturer()
        {
            ListEDP = EDPList.ListingEDP();
            List<string> Manufact = new List<string>();
            for (int i = 0; i < ListEDP.Count; i++)
            {
                string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + ListEDP[i] + "&ignoreCatalog=true";
                XmlTextReader reader = new XmlTextReader(URL);
                reader.WhitespaceHandling = WhitespaceHandling.Significant;

                while (reader.Read())
                {
                    if (reader.Name == "manufacturer")
                    {
                        string elementstring= reader.ReadElementString("manufacturer");
                        Manufact.Add(elementstring);
                    }

                }
            }
            Manufact = Manufact.Distinct().ToList();
            return (Manufact);
        }
    }
}