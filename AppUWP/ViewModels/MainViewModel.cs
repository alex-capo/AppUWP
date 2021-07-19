
namespace AppUWP.ViewModels
{
    using AppUWP.Base;
    using AppUWP.Services;
    using AppUWP.Views;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Navigation;
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<object> Items { get; set; }
        public DataTemplate ItemTemplate { get; set; }
        public void Navigate(string pageName)
        {
            switch (pageName)
            {
                case "tree":
                    Title = "Tree View";
                    MenuFrame.Navigate(typeof(TreeView));
                    break;
                case "pdf":
                    Title = "Pdf View";
                    MenuFrame.Navigate(typeof(PdfView));
                    break;
                case "ux":
                    Title = "UX View";
                    MenuFrame.Navigate(typeof(UxView));
                    break;
                default:
                    break;
            }
        }
        public override Task OnNavigatedTo(NavigationEventArgs args)
        {
            Items = new ObservableCollection<object>(ImagesDataSource.GetItems().Reverse().Skip(4));
            return null;
        }
        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            return null;
        }
    }
}
