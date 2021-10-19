using PeerIslands.Assignment.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PeerIslands.Assignment.ExtendedProblem.Models
{
    [XmlRoot(ElementName = "employees")]
    public class ExtendedEmployees : BaseEmployees<ExtentedEmployee>
    {
    }
}
