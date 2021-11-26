using System;
using NUnit.Framework;

namespace TestProject1.Tests
{
    public class SimpleTest : AbstractTest
    {
        [Test]
        public void Simple()
        {
            Console.Out.WriteLine("Just simple test to know browser is created and everything is fine");
        }
    }
}