// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WebView.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SFSafariViewControllerButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton UIWebViewButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton WKWebViewButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SFSafariViewControllerButton != null) {
                SFSafariViewControllerButton.Dispose ();
                SFSafariViewControllerButton = null;
            }

            if (UIWebViewButton != null) {
                UIWebViewButton.Dispose ();
                UIWebViewButton = null;
            }

            if (WKWebViewButton != null) {
                WKWebViewButton.Dispose ();
                WKWebViewButton = null;
            }
        }
    }
}