using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Xml;
using System.Xml.Serialization;

namespace Mudrolije.Models
{
    // XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc);
    
    [XmlRoot("mudrolije")]
    public class Mudrolije : List<mudrolija>{ }

    public class mudrolija
    {
        [XmlElement("mudrolijaId")]
        public int MudrolijaId { get; set; }

        [XmlElement("mudrolijaNaslov")]
        public string MudrolijaNaslov { get; set; }

        [XmlElement("vrsta")]
        public string Vrsta { get; set; }

        [XmlElement("opis")]
        public string Opis { get; set; }

        [XmlElement("stepen")]
        public int Stepen { get; set; }

        [XmlElement("period")]
        public string Period { get; set; }

        [XmlElement("smislenost")]
        public string Smislenost { get; set; }

        [XmlElement("uticaj")]
        public int Uticaj { get; set; }

        [XmlElement("slika")]
        public string Slika { get; set; }

        [XmlElement("link")]
        public string Link { get; set; }
    }
}