using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WebServiceDeserialization
{
    public class EDPList
    {
        public List<string> ListingEDP()
        {
            List<string> EDPs = new List<string>();
            XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=10&start=0");
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.ReadToFollowing("result"))
            {
                while (reader.ReadToFollowing("int"))
                {
                    if (reader.GetAttribute("name") == "EDP")
                    {
                        string attr = reader.GetAttribute("name");
                        string valuetext = reader.ReadElementString("int");

                        EDPs.Add(valuetext);
                    }
                }
            }
            return (EDPs);
        }

    }
}