using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebServiceDeserialization
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string NodeType, NodeName;
            XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.Read())
            {

                NodeType = reader.NodeType.ToString(); NodeName = reader.Name;
                // Print out info on node  
                Response.Write("Node Type: " + NodeType + "</br>");
                Response.Write("Node Name: " + NodeName + "</br></br>");
                Response.Write("");
            }
        }
    }
}