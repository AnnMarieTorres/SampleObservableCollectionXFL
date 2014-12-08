using System;
using Xamarin.Forms.Labs.Mvvm;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SampleObservableCollectionXFL
{
    public class FooViewModel : ViewModel
    {
        private ObservableCollection<FooModel> names;
        public ObservableCollection<FooModel> Names 
        { 
            get {
                return names;

            }
            set {
                this.SetProperty(ref names, value);
            }
        }

        private Command _loadItemsCommand;
        public Command LoadItemsCommand
        {
            get { return _loadItemsCommand ?? (_loadItemsCommand = new Command(ExecuteLoadItemsCommand)); }
        }

        public FooViewModel() {
            Names = new ObservableCollection<FooModel>();
        }

        private void ExecuteLoadItemsCommand()
        {
            Names.Add(new FooModel { MonkeyName = "Bob" });
            Names.Add(new FooModel { MonkeyName = "Jane" });
            Names.Add(new FooModel { MonkeyName = "Ivan" });
        }
    }
}

