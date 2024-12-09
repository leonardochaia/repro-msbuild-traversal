using Microsoft.Build.Locator;
using Repro;
using Xunit;

namespace MyNamespace
{
    /// <summary>
    /// Makes sure MSBuild is properly loaded for all tests
    /// </summary>
    public class BaseMSBuildTest
    {
        static BaseMSBuildTest()
        {
            MSBuildLocator.RegisterDefaults();
        }
    }


    public class TheTest : BaseMSBuildTest
    {
        [Fact]
        public void Test()
        {
            ReproTest.Test();
        }
    }
}