using System;
using Xunit;

namespace ClassLibrary1
{
    public class Class1
    {
        public static bool testFalse() => false;

        [ConditionalFact(nameof(testFalse))]
        public static void test()
        {
            Assert.True(true);
        }
    }
}
