using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PeerIslands.Assignment.ExtendedProblem.Models
{
    [XmlRoot(ElementName = "address")]
    public class Address
    {
        [XmlElement(ElementName = "doorno")]
        public int DoorNo { get; set; }

        [XmlElement(ElementName = "street")]
        public string Street { get; set; }

        [XmlElement(ElementName = "town")]
        public string Town { get; set; }

        [XmlElement(ElementName = "state")]
        public string State { get; set; }
    }
}
