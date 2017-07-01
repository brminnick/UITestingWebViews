 using NUnit.Framework;

using Xamarin.UITest;

namespace WebView.UITest
{
    [TestFixture(Platform.iOS)]
    public abstract class BaseTest
    {
        #region Fields
        IApp _app;
        Platform _platform;
        MainPage _mainPage;
        WebViewPage _webViewPage;
        #endregion

        #region Constructors
        protected BaseTest(Platform platform) => _platform = platform;
        #endregion

        #region Properties
		protected Platform Platform => _platform;
        protected IApp App => _app;
        protected MainPage MainPage => _mainPage ?? (_mainPage = new MainPage(App, Platform));
        protected WebViewPage WebViewPage => _webViewPage ?? (_webViewPage = new WebViewPage(App, Platform));
        #endregion

        #region Methods
        [SetUp]
        protected virtual void BeforeEachTest() =>  _app = AppInitializer.StartApp(Platform);
        #endregion
    }
}

