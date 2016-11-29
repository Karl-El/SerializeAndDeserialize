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
            //XmlReader xmlReader = XmlReader.Create("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            //while (xmlReader.Read())
            //{
            //    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "response"))
            //    {
            //        if (xmlReader.HasAttributes)
            //        {
            //            //Response.Write(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));
            //            string valuetext = xmlReader.ReadElementString("int");
            //            Response.Write("Value:" + valuetext);
            //            Response.Write("</br>");
            //        }
            //    }
            //}

            /* //------------------------------------------------------------------------------------------ NOT WORKING READER
             XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
             reader.WhitespaceHandling = WhitespaceHandling.Significant;
             reader.ReadStartElement("response");
             reader.Read(); // read next element
             reader.Read(); // read next element
             while (reader.LocalName == "result")
             {
                 String  value;
                 reader.ReadStartElement("result");
                 value = reader.ReadElementString("doc");
                 Response.Write("Value: " + value);
                 Response.Write("</br>");
                 reader.ReadEndElement();
                 reader.Read();
             } */


            //-----------------------------------------------------------------------------------------------------WORKING READER
            XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=40&start=0");
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.ReadToFollowing("result"))
            {
                while (reader.ReadToFollowing("int"))
                {
                    if (reader.GetAttribute("name") == "EDP")
                    {
                        string attr = reader.GetAttribute("name");
                        string valuetext = reader.ReadElementString("int");

                        //Response.Write("Attribute Name: " + attr);
                        //Response.Write("</br>");
                        Response.Write("Value:" + valuetext);
                        //Response.Write("</br>");
                        Response.Write("</br>");
                    }
                }

            }
        }

    }
}