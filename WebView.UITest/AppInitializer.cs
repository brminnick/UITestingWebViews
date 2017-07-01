using Xamarin.UITest;
using Xamarin.UITest.Configuration;

namespace WebView.UITest
{
    public static class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            switch (platform)
            {
                case Platform.Android:
                    return ConfigureApp.Android.StartApp(AppDataMode.Clear);
                case Platform.iOS:
                    return ConfigureApp.iOS.StartApp(AppDataMode.Clear);
                default:
                    throw new System.Exception("Platform Unsupported");
            }
        }
    }
}
