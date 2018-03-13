using System.Security.Cryptography.Xml;

namespace DigestMethodTest
{
    public static class XmlReference
    {
        public static string GetDigestMethod()
        {
            return new Reference().DigestMethod;
        }
    }
}