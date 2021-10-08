using PeerIslands.Assignment.Common.Models;
using System.Xml.Serialization;

namespace PeerIslands.Assignment.ExtendedProblem.Models
{
    [XmlRoot(ElementName = "employees")]
    public class ExtentedEmployee : Employee
    {
        [XmlElement(ElementName = "address")]
        public Address Address { get; set; }
    }
}
