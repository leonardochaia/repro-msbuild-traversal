using System;
using System.IO;
using System.Xml;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Locator;
using Repro;
using Xunit;

namespace MyNamespace
{
    public class Test2 : BaseMSBuildTest
    {
        [Fact]
        public void Test()
        {
            ReproTest.Test();
        }
    }
}