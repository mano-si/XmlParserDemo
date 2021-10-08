using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PeerIslands.Assignment.Common.Models
{
    [XmlRoot(ElementName = "employees")]
    public class BaseEmployees<T> where T:Employee
    {
        public BaseEmployees()
        {
            ListOfEmployees = new List<T>();
        }

        [XmlElement(ElementName = "employee")]
        public List<T> ListOfEmployees { get; set; }
    }
}
