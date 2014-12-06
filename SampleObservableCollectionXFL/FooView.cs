using System;
using Xamarin.Forms.Labs.Mvvm;
using Xamarin.Forms;

namespace SampleObservableCollectionXFL
{
    public class FooView : BaseView
    {
        private FooViewModel ViewModel
        {
            get { return BindingContext as FooViewModel; }
        }

        public FooView()
        {
            var list = new ListView();

            list.SetBinding(ListView.ItemsSourceProperty, new Binding("Names"));

            var cell = new DataTemplate(typeof(TextCell));

            cell.SetBinding(TextCell.TextProperty, "MonkeyName");

            list.ItemTemplate = cell;

            Content = new StackLayout {
                Children = {
                    list
                }
            };

        }

        protected override void OnAppearing() {
            base.OnAppearing();

            if (ViewModel == null)
                return;


            ViewModel.LoadItemsCommand.Execute(null);
        }
    }
}

