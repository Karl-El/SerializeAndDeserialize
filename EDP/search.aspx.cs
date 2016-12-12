using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDP
{
    public partial class search : System.Web.UI.Page
    {
        string q = "", rows = "5";
        SearchedEDP SearchedEDP = new SearchedEDP();
        DataSourceManufacturer DataSourceManufacturer = new DataSourceManufacturer();
        List<string> EDPSearched = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            q = Request.QueryString["q"];
            if (!IsPostBack)
            {
                EDPSearched = SearchedEDP.EDPSearching(q, rows);
                DataSourceRadioBrand();
            }
        }

        protected void drpdwnlst_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            rows = drpdwnlst_View.SelectedValue;
            plchldr_Prod.Controls.Add(new LiteralControl(rows));
        }

        public void DataSourceRadioBrand()
        {
            List<string> Brands;
            Brands = DataSourceManufacturer.ListingEDPbyManufact(EDPSearched);
            if (!IsPostBack)
            {
                for (int i = 0; i < Brands.Count; i++)
                {
                    rdbtnlst_Brand.Items.Add(new ListItem(Brands[i]));
                }
            }
        }
    }

}