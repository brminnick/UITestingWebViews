using NUnit.Framework;

using Xamarin.UITest;

namespace WebView.UITest
{
    public class ReplTests : BaseTest
    {
        public ReplTests(Platform platform) : base(platform)
        {
        }

        //[Ignore]
        [Test]
        public void ReplTest()
        {
            App.Repl();
        }
    }
}
