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
        EDPList EDPList = new EDPList();
        protected void Page_Load(object sender, EventArgs e)
        {

            _rptrEDP.DataSource = EDPList.ListingEDP();
            _rptrEDP.DataBind();
        }
        protected void _rptrEDP_PreRender(object sender, EventArgs e)
        {
            foreach (RepeaterItem item in _rptrEDP.Items)
            {
                if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
                {
                    string DetailString = "";
                    Label lbl_Name = (Label)item.FindControl("lbl_Name");
                    Label lbl_Description = (Label)item.FindControl("lbl_Description");
                    Label lbl_Price = (Label)item.FindControl("lbl_Price");
                    Label lbl_Manufacturer = (Label)item.FindControl("lbl_Manufacturer");
                    Label lbl_Availability = (Label)item.FindControl("lbl_Availability");
                    Image img_Prod = (Image)item.FindControl("img_Prod");
                    List<string> ListEDP;
                    ListEDP = EDPList.ListingEDP();
                    for (int i = 0; i < ListEDP.Count; i++)
                    {
                        string URL = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + ListEDP[i] + "&ignoreCatalog=true";
                        XmlTextReader reader = new XmlTextReader(URL);
                        reader.WhitespaceHandling = WhitespaceHandling.Significant;
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
                        //if (reader.Name == "name")
                        //{
                        //    lbl_Name.Text = reader.ReadElementString("name");
                        //}
                        //else { lbl_Name.Text = "Hello"; }
                        //if (reader.Name == "description")
                        //{
                        //    lbl_Description.Text = reader.ReadElementString("description");
                        //}
                        //else { lbl_Description.Text = "empty"; }
                        //if (reader.Name == "finalPrice")
                        //{
                        //    lbl_Price.Text = reader.ReadElementString("finalPrice");
                        //}
                        //else { lbl_Price.Text = "empty"; }
                        //if (reader.Name == "xlg")
                        //{
                        //    img_Prod.ImageUrl = reader.ReadElementString("xlg");
                        //}
                        //else { img_Prod.ImageUrl = "empty"; }
                        //if (reader.Name == "manufacturer")
                        //{
                        //    lbl_Manufacturer.Text = reader.ReadElementString("manufacturer");
                        //}
                        //else { lbl_Manufacturer.Text = "empty"; }
                        //if (reader.Name == "availabilityDescription")
                        //{
                        //    lbl_Availability.Text = reader.ReadElementString("availabilityDescription");
                        //}
                        //else { lbl_Availability.Text = "empty"; }

                    }
                    }
                }
            }
        }
    }
//    ProdDetail ProdInfo = new ProdDetail();
//    Label lbl_Name = (Label)item.FindControl("lbl_Name");
//    string NAME = "", DESCRIPTION = "", FINALPRICE = "", XLG = "", MANUFACTURER = "", AVAILABILITYDESCRIPTION = "";
//    string EDP = "";

//    List<string> ListEDP;
//    ListEDP = EDPList.ListingEDP();
//    for (int i = 0; i < ListEDP.Count; i++)
//    {
//        EDP = ListEDP[i];
//        ProdInfo.showDetails(EDP, NAME, DESCRIPTION, FINALPRICE, XLG, MANUFACTURER, AVAILABILITYDESCRIPTION);
//    }
//}
