using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PeerIslands.Assignment.Common.Helpers
{
    public class XmlParser : IXmlParser
    {
        public T Deserialize<T>(String xml)
        {
            T returnedXmlClass = default;

            try
            {
                using (TextReader reader = new StringReader(xml))
                {
                    try
                    {
                        returnedXmlClass =
                            (T)new XmlSerializer(typeof(T)).Deserialize(reader);
                    }
                    catch (InvalidOperationException ex)
                    {
                        // String passed is not XML. Log 
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                //log
                throw;
            }

            return returnedXmlClass;
        }

        public string Serialize<T>(T type)
        {
            var serializer = new XmlSerializer(typeof(T));
            var xml = "";

            try
            {
                using (var sww = new StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create(sww))
                    {
                        serializer.Serialize(writer, type);
                        xml = sww.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                //log
                throw;
            }


            return xml;
        }
    }
}
