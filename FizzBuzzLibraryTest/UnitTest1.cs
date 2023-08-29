using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
using System.Linq;

namespace FizzBuzzLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        TwistedFizzBuzz lib=new TwistedFizzBuzz();
        List<string> result=lib.FizzBuzzForRange(new int[]{3,6,9,18});
         Assert.IsTrue(!result.Any(x=>string.Equals(x,"buzz",StringComparison.OrdinalIgnoreCase)),
                   string.Format("Expected to contain only fizz but had buzz"));
    }

    [TestMethod]
    public void TestMethod2()
    {
        TwistedFizzBuzz lib=new TwistedFizzBuzz();
        List<string> result=lib.FizzBuzzForRange(new int[]{5,10,15});
         Assert.IsTrue(!result.Any(x=>string.Equals(x,"fizz",StringComparison.OrdinalIgnoreCase)),
                   string.Format("Expected to contain only buzz but had fizz"));
    }

    [TestMethod]
    public void TestMethod3()
    {
        TwistedFizzBuzz lib=new TwistedFizzBuzz();
        List<string> result=lib.FizzBuzzForRange(new int[]{15,30,75});
         Assert.IsTrue(result.All(x=>string.Equals(x,"fizzbuzz",StringComparison.OrdinalIgnoreCase)),
                   string.Format("Expected to contain only fizzbuzz"));
    }


    [TestMethod]
    public void TestMethod4()
    {
        TwistedFizzBuzz lib=new TwistedFizzBuzz("Fizz","Fizz",5,5);
        List<string> result=lib.FizzBuzzForRange(new int[]{15,30,75});
         Assert.IsTrue(result.All(x=>string.Equals(x,"fizzbuzz",StringComparison.OrdinalIgnoreCase)),
                   string.Format("Expected to contain only fizzbuzz"));
    }
}