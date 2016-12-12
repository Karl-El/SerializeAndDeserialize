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
        //string SelectedRow = "";
        string Information = "";
        string q = "", rows = "1";
        SearchedEDP SearchedEDP = new SearchedEDP();
        DataSourceManufacturer DataSourceManufacturer = new DataSourceManufacturer();
        Detailed Detailed = new Detailed();

        protected void Page_Load(object sender, EventArgs e)
        {
            q = Request.QueryString["q"];
            if (!IsPostBack)
            {
                Brands();
                ViewAll();
            }
        }

        protected void drpdwnlst_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            rows = drpdwnlst_View.SelectedValue;
            ViewByRow();
            Brands();
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
            EDPs = SearchedEDP.EDPSearching(q, rows);
            Information = Detailed.ShowDetails(EDPs);
            plchldr_Prod.Controls.Add(new LiteralControl(Information));
        }

        public void Brands()
        {
            List<string> Brands; List<string> EDPs;
            EDPs = SearchedEDP.EDPSearching(q, rows);
            Brands = DataSourceManufacturer.ListingEDPbyManufact(EDPs);
            if (IsPostBack)
            {
                rdbtnlst_Brand.Items.Clear();
                for (int i = 0; i < Brands.Count; i++)
                {
                    rdbtnlst_Brand.Items.Add(new ListItem(Brands[i]));
                }
            }
        }

        //public void BrandByRow()
        //{
        //    List<string> Brands;
        //    EDPSearched = SearchedEDP.EDPSearching(q, SelectedRow);
        //    Brands = DataSourceManufacturer.ListingEDPbyManufact(EDPSearched);
        //    if (IsPostBack)
        //    {
        //        rdbtnlst_Brand.Items.Clear();
        //        for (int i = 0; i < Brands.Count; i++)
        //        {
        //            rdbtnlst_Brand.Items.Add(new ListItem(Brands[i]));
        //        }
        //    }
        //}
    }

}