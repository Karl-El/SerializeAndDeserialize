using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WebServiceDeserialization
{
    public class EDPbyBrand
    {
        EDPList EDPList = new EDPList();
        public List<string> ListingBrandEDP(string ManufactSelect)
        {
            string EDPforBrand = "";
            string ReadManufact = "";
            List<string> ListEDP;
            ListEDP = EDPList.ListingEDP();
            List<string> BrandEDPs = new List<string>();
            for (int i = 0; i < ListEDP.Count; i++)
            {
                #region FOR START READ A SPECIFIC BRAND/MANUFACTURER
                {
                    string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + ListEDP[i] + "&ignoreCatalog=true";
                    XmlTextReader reader = new XmlTextReader(URL);
                    reader.WhitespaceHandling = WhitespaceHandling.Significant;
                    while (reader.Read())
                    {
                        if (reader.Name == "edp")
                        {
                            EDPforBrand = reader.ReadElementString("edp");
                        }
                        if (reader.Name == "manufacturer")
                        {
                            ReadManufact = reader.ReadElementString("manufacturer");
                            if (ReadManufact == ManufactSelect)
                            {
                                string EDPSTRINGLISTBRANDED = "";
                                BrandEDPs.Add(EDPforBrand);
                                EDPSTRINGLISTBRANDED += EDPforBrand;
                                break;
                            }
                        }
                    }
                }
                #endregion
            }
            return (BrandEDPs);
        }
    }
}