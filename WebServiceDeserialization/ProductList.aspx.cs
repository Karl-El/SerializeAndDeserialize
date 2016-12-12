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
        string ProdInfo = "";
        string SelectedManufact = "";
        EDPList EDPList = new EDPList();
        Manufacturer Manufacturer = new Manufacturer();
        EDPbyBrand EDPbyBrand = new EDPbyBrand();
        ProdDetail ProdDetail = new ProdDetail();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AllProducts();
                _plchldrProdInfo.Focus();
                DataSourceRadioBrand();
            }
        }

        public void DataSourceRadioBrand()
        {
            List<string> ListManufact;
            ListManufact = Manufacturer.ListManufacturer();
            if (!IsPostBack)
            {
                for (int i = 0; i < ListManufact.Count; i++)
                {
                    _rdbtnlstManufact.Items.Add(new ListItem(ListManufact[i]));
                }
            }
        }


        protected void _rdbtnlstManufact_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedManufact = _rdbtnlstManufact.SelectedItem.Text;
            ProdByBrand();
        }

        protected void _btnClearFilter_Click(object sender, EventArgs e)
        {
            _rdbtnlstManufact.ClearSelection();
            AllProducts();
        }

        public void AllProducts()
        {
            List<string> EDPs;
            EDPs = EDPList.ListingEDP();
            ProdInfo = ProdDetail.AllProducts(EDPs);
            _plchldrProdInfo.Controls.Add(new LiteralControl(ProdInfo));
            //Response.Write(ProdInfo);
        }
        public void ProdByBrand()
        {
            List<string> EDPs;
            EDPs = EDPbyBrand.ListingBrandEDP(SelectedManufact);
            ProdInfo = ProdDetail.AllProducts(EDPs);
            _plchldrProdInfo.Controls.Add(new LiteralControl(ProdInfo));
            //Response.Write(ProdInfo);
        }

    }
}