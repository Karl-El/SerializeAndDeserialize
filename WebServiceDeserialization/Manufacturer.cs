using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WebServiceDeserialization
{
    public class Manufacturer
    {
        public List<string> ListManufacturer()
        { List<string> Manufact = new List<string>();
            XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0");
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.ReadToFollowing("result"))
            {
                while (reader.ReadToFollowing("int"))
                {
                    if (reader.GetAttribute("name") == "EDP")
                    {
                        string valuetext = reader.ReadElementString("int");

                        Manufact.Add(valuetext);
                    }
                }
            }
            return (Manufact);
        }
        
    }
}