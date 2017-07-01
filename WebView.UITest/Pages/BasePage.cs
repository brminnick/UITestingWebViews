using Xamarin.UITest;

namespace WebView.UITest
{
    public abstract class BasePage
    {
        #region Constructors
        protected BasePage(IApp app, Platform platform)
        {
            App = app;

            OnAndroid = platform == Platform.Android;
            OniOS = platform == Platform.iOS;
        }
        #endregion

        #region Properties
        protected IApp App { get; }
        protected bool OnAndroid { get; }
        protected bool OniOS { get; }
        #endregion
    }
}

