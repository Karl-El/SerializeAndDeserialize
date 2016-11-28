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

            XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            if (reader.ReadToDescendant("result"))
            {
                reader.Read();//this moves reader to next node which is text 
               string  result = reader.Value; //this might give value than 
                Response.Write("Value:" + result);
                Response.Write("</br>");
            }


            /* //-----------------------------------------------------------------------------------------------------WORKING READ
            while (reader.ReadToFollowing("int"))
            {
                string attr = reader.GetAttribute("name");
                string valuetext = reader.ReadElementString("int");

                Response.Write("Attribute Name: "+attr);
                Response.Write("</br>");
                Response.Write("Value:"+valuetext);
                Response.Write("</br>");
                Response.Write("</br>");
                
            }*/

        }
    }
}