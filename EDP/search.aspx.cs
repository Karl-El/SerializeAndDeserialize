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
        string SelectedRow = "";
        string Information = "";
        string q = "", rows = "5";
        SearchedEDP SearchedEDP = new SearchedEDP();
        DataSourceManufacturer DataSourceManufacturer = new DataSourceManufacturer();
        Detailed Detailed = new Detailed();
        List<string> EDPSearched = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            q = Request.QueryString["q"];
            if (!IsPostBack)
            {
                ViewAll();
            }
        }

        protected void drpdwnlst_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedRow = drpdwnlst_View.SelectedValue;
            ViewByRow();
        }


        public void ViewAll()
        {
            List<string> EDPs;
            EDPs = SearchedEDP.EDPSearching(q, rows);
            Information = Detailed.ShowDetails(EDPs);
            plchldr_Prod.Controls.Add(new LiteralControl(Information));
        }

        public void ViewByRow()
        {
            List<string> EDPs;
            EDPs = SearchedEDP.EDPSearching(q, SelectedRow);
            Information = Detailed.ShowDetails(EDPs);
            plchldr_Prod.Controls.Add(new LiteralControl(Information));
        }

        public void BrandAll()
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