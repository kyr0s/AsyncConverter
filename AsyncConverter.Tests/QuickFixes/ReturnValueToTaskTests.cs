using AsyncConverter.QuickFixes;
using JetBrains.ReSharper.FeaturesTestFramework.Intentions;
using NUnit.Framework;

namespace AsyncConverter.Tests.QuickFixes
{
    [TestFixture]
    public class ReturnValueToTaskTests : CSharpQuickFixTestBase<ReturnValueToTask>
    {

        protected override string RelativeTestDataPath => @"ReturnValueToTaskTests";

        [Test]
        public void Test01()
        {
            DoTestFiles("Test01.cs");
        }
    }
}
