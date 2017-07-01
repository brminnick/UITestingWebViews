using Xamarin.UITest;

namespace WebView.UITest
{
    public class WebViewPage : BasePage
    {
        public WebViewPage(IApp app, Platform platform) : base(app, platform)
        {
        }

        public void EnterSearch(string text)
        {
            App.EnterText(x => x.Class("UIWebView").Css("INPUT#lst-ib"), text);
            App.Tap(x => x.Class("UIWebView").Css("DIV.sbico"));
            App.Screenshot($"Entered Search: {text}");
        }
    }
}
