using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFE
{
    [System.Xml.Serialization.XmlRoot("tokens")]
    public class tokensave
    {
        [System.Xml.Serialization.XmlElement("token")]
        public System.Collections.Generic.List<LIFE.tokensave> token { get; set; }

        [System.Xml.Serialization.XmlAttribute("name")]
        public String ID { get; set; }
        
        [System.Xml.Serialization.XmlElement("ck")]
        public String consumerkey { get; set; }
        
        [System.Xml.Serialization.XmlElement("cs")]
        public String consumersecret { get; set; }
        
        [System.Xml.Serialization.XmlElement("ak")]
        public String accesskey { get; set; }

        [System.Xml.Serialization.XmlElement("as")]
        public String accesssecret { get; set; }

    }

    [System.Xml.Serialization.XmlRoot("settings")]
    public class clientsetting
    {
        [System.Xml.Serialization.XmlElement("setting")]
        public LIFE.clientsetting setting { get; set; }

        [System.Xml.Serialization.XmlElement("StartAppLoginAcount")]
        public String StartAppLoginAcount { get; set; }

        [System.Xml.Serialization.XmlElement("StartAppTLLoadTweetCount")]
        public String StartAppTLLoadTweetCount { get; set; }
    }
}
