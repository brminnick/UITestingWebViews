using Xamarin.UITest;

using WebView.Shared;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace WebView.UITest
{
    public class MainPage : BasePage
    {
        readonly Query _sfSafariViewControllerButton, _wkWebViewButton, _uiWebViewButton;

        public MainPage(IApp app, Platform platform) : base(app, platform)
        {
            _sfSafariViewControllerButton = x => x.Marked(AutomationIdConstants.SFSafariViewControllerButton);
            _wkWebViewButton = x => x.Marked(AutomationIdConstants.WKWebViewButton);
            _uiWebViewButton = x => x.Marked(AutomationIdConstants.UIWebViewButton);
        }

        public void TapSFSafariViewControllerButton()
        {
            App.Tap(_sfSafariViewControllerButton);
            App.Screenshot("Tapped SF Safari View Controller");
        }

        public void TapWKWebViewButton()
        {
			App.Tap(_wkWebViewButton);
			App.Screenshot("Tapped WKWebView Button");
        }

		public void TapUIWebViewButton()
		{
			App.Tap(_uiWebViewButton);
			App.Screenshot("Tapped UIWebViewButton");
		}
    }
}
