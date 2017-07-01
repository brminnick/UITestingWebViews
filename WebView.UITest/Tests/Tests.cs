using NUnit.Framework;

using Xamarin.UITest;

namespace WebView.UITest
{
    public class Tests : BaseTest
    {
        public Tests(Platform platform) : base(platform)
        {
        }

        [Test]
        public void AppLaunches()
        {
            App.Screenshot("First screen");
        }

        [Test]
        public void UIWebViewTest()
        {
            MainPage.TapUIWebViewButton();
            WebViewPage.EnterSearch("Hello World");
        }

        [Test]
        public void WKWebViewTest()
        {
            MainPage.TapWKWebViewButton();
            WebViewPage.EnterSearch("Hello World");
        }
    }
}
