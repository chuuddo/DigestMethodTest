using DigestMethodTest;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class XmlReferenceTests
    {
        [Test]
        public void GetDigestMethod()
        {
#if NET452
            var expected = "http://www.w3.org/2000/09/xmldsig#sha1";
#endif
#if NET471
            var expected = "http://www.w3.org/2001/04/xmlenc#sha256";
#endif
            Assert.AreEqual(expected, XmlReference.GetDigestMethod());
        }
    }
}