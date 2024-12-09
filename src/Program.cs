using Microsoft.Build.Locator;

namespace Repro
{
    public class Program
    {
        static Program()
        {
            MSBuildLocator.RegisterDefaults();
        }
        
        static void Main(string[] args)
        {
            ReproTest.Test();
        }
    }
}