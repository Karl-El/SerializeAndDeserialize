﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDP
{
    public partial class First : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnbtn_Search_Click(object sender, EventArgs e)
        {
            string q = txt_Search.Text.Trim();
            Response.Redirect("search.aspx?q=" + q);
        }
    }
}