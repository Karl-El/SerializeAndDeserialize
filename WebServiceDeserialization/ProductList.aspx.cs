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
        }
        protected void _rptrEDP_PreRender(object sender, EventArgs e)
        {
            foreach (RepeaterItem item in _rptrEDP.Items)
            {
                if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
                {
                    ProdDetail ProdInfo = new ProdDetail();
                    Label lbl_Name = (Label)(_rptrEDP.FindControl("lbl_Name"));
                    string NAME = "", DESCRIPTION = "", FINALPRICE = "", XLG = "", MANUFACTURER = "", AVAILABILITYDESCRIPTION = "";
                    string EDP = "6926988";
                    //EDPList EDPList = new EDPList();
                    //_rptrEDP.DataSource = EDPList.ListingEDP();
                    //_rptrEDP.DataBind();

                    //List<string> ListEDP = EDPList.ListingEDP();
                    //for (int i = 0; i < ListEDP.Count; i++)
                    //{
                    //    EDP = ListEDP[i];
                    //}
                    ProdInfo.showDetails(EDP, NAME, DESCRIPTION, FINALPRICE, XLG, MANUFACTURER, AVAILABILITYDESCRIPTION);
                    lbl_Name.Text = NAME;


                }

            }
        }
    }
}
