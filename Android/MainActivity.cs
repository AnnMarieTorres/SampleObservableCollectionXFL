using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms.Labs.Droid;
using Xamarin.Forms.Labs.Services;


namespace SampleObservableCollectionXFL.Android
{
    [Activity(Label = "SampleObservableCollectionXFL.Android.Android", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : XFormsApplicationDroid
    {
        protected override void OnCreate(Bundle bundle)
        {
            this.IoC();

            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);

            SetPage(App.GetMainPage());
        }

        private void IoC() 
        {
            var resolverContainer = new SimpleContainer();

            resolverContainer.Register<IDependencyContainer>(t => resolverContainer);

            Resolver.SetResolver(resolverContainer.GetResolver());
        }
    }
}

