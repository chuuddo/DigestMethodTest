using System;

namespace DigestMethodTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
#if NET452
            var target = "net452";
#endif
#if NET471
           var target = "net471";
#endif
            Console.WriteLine($"On {target} XmlReference.GetDigestMethod() returns {XmlReference.GetDigestMethod()}");
        }
    }
}