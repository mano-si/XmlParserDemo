using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PeerIslands.Assignment.Common.Models
{
    [XmlRoot(ElementName = "employees")]
    public class Employees : BaseEmployees<Employee>
    {
    }
}
