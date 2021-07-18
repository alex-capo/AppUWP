namespace AppUWP.ViewModels
{
    using AppUWP.Base;
    using AppUWP.Interfaces;
    using AppUWP.Models;
    using AppUWP.Services;
    using Newtonsoft.Json;
    using System;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using Windows.UI.Xaml.Navigation;
    public class TreeViewModel : ViewModelBase
    {
        public ObservableCollection<ItemTreeView> DataTreeView { get; set; }

        private readonly IRepository _repository = new Repository();

        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        public TreeViewModel()
        {
            Title = "Tree View";
            LoadTreeView();
        }
        private void LoadTreeView()
        {
            Object dataTreeView = localSettings.Values["DataTreeView"];
            if (dataTreeView != null)
            {                
                DataTreeView = JsonConvert.DeserializeObject<ObservableCollection<ItemTreeView>>(dataTreeView.ToString());
            }
            else
            {
                DataTreeView = new ObservableCollection<ItemTreeView>(_repository.GetDataTreeView());
            }
        }
        public void SaveSelection() => localSettings.Values["DataTreeView"] = JsonConvert.SerializeObject(DataTreeView);
        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            return null;
        }
        public override Task OnNavigatedTo(NavigationEventArgs args)
        {
            return null;
        }
    }


}
