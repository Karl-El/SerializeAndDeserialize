using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceDeserialization
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static void LabelCssClass(Control root)
        {
            foreach (Control control in root.Controls)
            {
                if (control is Label)
                {
                    var label = control as Label;
                    label.CssClass = "control-label";
                }
                else
                {
                    LabelCssClass(control);
                }
            }
        }

    }
}