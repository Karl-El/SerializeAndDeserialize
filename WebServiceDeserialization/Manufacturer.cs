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
        {
            List<string> Manufact = new List<string>();
            XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=10&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.ReadToFollowing("lst"))
            {
                if (reader.GetAttribute("name") == "Manufacturer")
                {
                    while (reader.ReadToFollowing("int"))
                    {
                        string valuetext = reader.GetAttribute("name");
                        Manufact.Add(valuetext);
                    }
                }
            }
            //while (reader.Read())
            //{
            //    if ()
            //    {

            //    }
            //}
            return (Manufact);
        }

    }
}