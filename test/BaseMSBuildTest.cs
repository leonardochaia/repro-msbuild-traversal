using Microsoft.Build.Locator;

namespace MyNamespace
{
    public class BaseMSBuildTest
    {
        static BaseMSBuildTest()
        {
            MSBuildLocator.RegisterDefaults();
        }
    }
}