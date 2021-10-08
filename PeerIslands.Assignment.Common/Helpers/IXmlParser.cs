using System;

namespace PeerIslands.Assignment.Common.Helpers
{
    public interface IXmlParser
    {
        T Deserialize<T>(String xml);

        string Serialize<T>(T type);
    }
}
