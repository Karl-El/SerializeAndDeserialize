using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceDeserialization
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string EDP = "";
            EDPList EDPList = new EDPList();
            _rptrEDP.DataSource = EDPList.ListingEDP();
            _rptrEDP.DataBind();

            List<string> ListEDP = EDPList.ListingEDP();
            for (int i = 0; i < ListEDP.Count; i++)
            {
                EDP += ListEDP[i];
            }
            Response.Write(EDP);
        }
    }
}