using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PeerIslands.Assignment.Common.Models
{
    public class Employee
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "age")]
        public int Age { get; set; }

        [XmlElement(ElementName = "designation")]
        public string Designation { get; set; }
    }
}
