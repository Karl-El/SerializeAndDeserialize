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
                    ProdDetail ProdInfo = new ProdDetail();
                    Label lbl_Name = (Label)item.FindControl("lbl_Name");
                    string NAME = "", DESCRIPTION = "", FINALPRICE = "", XLG = "", MANUFACTURER = "", AVAILABILITYDESCRIPTION = "";
                    string EDP = "";

                    List<string> ListEDP;
                    ListEDP = EDPList.ListingEDP();
                    for (int i = 0; i < ListEDP.Count; i++)
                    {
                        EDP = ListEDP[i];
                        ProdInfo.showDetails(EDP, NAME, DESCRIPTION, FINALPRICE, XLG, MANUFACTURER, AVAILABILITYDESCRIPTION);
                    }
                }

            }
        }
    }
}
