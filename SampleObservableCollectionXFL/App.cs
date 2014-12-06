using System;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Mvvm;

namespace SampleObservableCollectionXFL
{
    public class App
    {
        public static Page GetMainPage()
        {	
            ViewFactory.Register<FooView, FooViewModel>();

            return ViewFactory.CreatePage<FooViewModel>();
        }
    }
}

