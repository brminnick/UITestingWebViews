using System;

using UIKit;
using WebKit;
using Foundation;
using CoreGraphics;
using SafariServices;
using WebView.Shared;

namespace WebView.iOS
{
    public partial class ViewController : UIViewController
    {
        #region Constant Fields
        readonly NSUrl _googleNSUrl = new NSUrl("https://google.com");
        #endregion

        #region Constructors
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        #endregion

        #region Methods
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SFSafariViewControllerButton.AccessibilityIdentifier = AutomationIdConstants.SFSafariViewControllerButton;
            WKWebViewButton.AccessibilityIdentifier = AutomationIdConstants.WKWebViewButton;
            UIWebViewButton.AccessibilityIdentifier = AutomationIdConstants.UIWebViewButton;
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

			SFSafariViewControllerButton.TouchUpInside += HandleSFSafariViewControllerButtonTouchUpInside;
			WKWebViewButton.TouchUpInside += HandleWKWebViewButtonTouchUpInside;
			UIWebViewButton.TouchUpInside += HandleUIWebViewButtonTouchUpInside;
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            SFSafariViewControllerButton.TouchUpInside -= HandleSFSafariViewControllerButtonTouchUpInside;
            WKWebViewButton.TouchUpInside -= HandleWKWebViewButtonTouchUpInside;
            UIWebViewButton.TouchUpInside -= HandleUIWebViewButtonTouchUpInside;
        }

        async void HandleSFSafariViewControllerButtonTouchUpInside(object sender, EventArgs e)
        {
            var linkInSFSafariViewController = new SFSafariViewController(_googleNSUrl);

            await PresentViewControllerAsync(linkInSFSafariViewController, true);
        }

        void HandleWKWebViewButtonTouchUpInside(object sender, EventArgs e)
        {
            var webView = new WKWebView(new CGRect(0, 20, View.Frame.Width, View.Frame.Height - 20), new WKWebViewConfiguration());
            View.AddSubview(webView);

            webView.LoadRequest(new NSUrlRequest(_googleNSUrl));
        }

        void HandleUIWebViewButtonTouchUpInside(object sender, EventArgs e)
        {
            var webView = new UIWebView(new CGRect(0, 20, View.Frame.Width, View.Frame.Height - 20));
            View.AddSubview(webView);

            webView.LoadRequest(new NSUrlRequest(_googleNSUrl));
        }
        #endregion
    }
}
