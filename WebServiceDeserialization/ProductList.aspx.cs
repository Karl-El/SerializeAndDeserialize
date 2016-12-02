using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebServiceDeserialization
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ProdDetail ProdInfo = new ProdDetail();
            //string STORE = "", NAME = "", DESCRIPTION = "", FINALPRICE = "", XLG = "", MANUFACTURER = "", AVAILABILITYDESCRIPTION = "";
            //string EDP = "";
            //EDPList EDPList = new EDPList();
            //_rptrEDP.DataSource = EDPList.ListingEDP();
            //_rptrEDP.DataBind();

            //List<string> ListEDP = EDPList.ListingEDP();
            //for (int i = 0; i < ListEDP.Count; i++)
            //{
            //    EDP = ListEDP[i];
            //}
            string inputedp, store, name, description, finalPrice, xlg, manufacturer, availabilityDescription;
            inputedp = "8900680";
            string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=";
            URL += inputedp;
            URL += "&ignoreCatalog=true";
            XmlTextReader reader = new XmlTextReader(URL);
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.ReadToFollowing("productService"))
            {
                //while (reader.ReadToFollowing("getProductInfo"))
                //{
                //    while (reader.ReadToFollowing("result"))
                //    {
                //        while (reader.ReadToFollowing("item"))
                //        {
                //            while (reader.ReadToFollowing("productDetails"))
                //            {
                                while (reader.Read())
                                {
                                    if (reader.Name == "name")
                                    {
                                        name = reader.ReadElementString("name");
                                    }
                                    else { name = "empty"; }
                                    if (reader.Name == "store")
                                    {
                                        store = reader.ReadElementString("store");
                                    }
                                    else { store = "empty"; }
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
                                    Response.Write(inputedp + store + name + description + finalPrice + xlg + manufacturer + availabilityDescription);
                                }
                            }
                        }
                    }
                }
                //ProdInfo.showDetails("", STORE, NAME, DESCRIPTION, FINALPRICE, XLG, MANUFACTURER, AVAILABILITYDESCRIPTION);
//            }
//        }
//    }
//}