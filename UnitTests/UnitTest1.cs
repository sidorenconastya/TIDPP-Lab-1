using Resolver;
using Xunit;

namespace UnitTests
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      var actualResult = Util.ResolveEquation(1, -5, 6);

      Assert.Contains(3, actualResult);
      Assert.Contains(2, actualResult);
    }
    
    [Fact]
    public void Test2()
    {
      var actualResult = Util.ResolveEquation(0, 2, 4);

      Assert.Contains(-2, actualResult);
    }
  }
}