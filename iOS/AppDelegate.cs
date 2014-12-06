using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Services;
using Xamarin.Forms.Labs.iOS;

namespace SampleObservableCollectionXFL.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : XFormsApplicationDelegate
    {
        UIWindow window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            this.IoC();

            Forms.Init();

            window = new UIWindow(UIScreen.MainScreen.Bounds);
			
            window.RootViewController = App.GetMainPage().CreateViewController();
            window.MakeKeyAndVisible();
			
            return true;
        }

        private void IoC() 
        {
            var resolverContainer = new SimpleContainer();

            resolverContainer.Register<IDependencyContainer>(t => resolverContainer);

            Resolver.SetResolver(resolverContainer.GetResolver());
        }
    }
}

