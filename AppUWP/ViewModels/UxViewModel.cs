using AppUWP.Base;
using AppUWP.Services;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

namespace AppUWP.ViewModels
{
    public class UxViewModel : ViewModelBase
    {
        public ObservableCollection<object> NatureItems { get; set; }
        public ObservableCollection<object> AnimalItems { get; set; }
        public ObservableCollection<object> CityItems { get; set; }
        public ObservableCollection<object> MotorItems { get; set; }
        public DataTemplate ItemTemplate { get; set; }
        public UxViewModel()
        {
            var items = ImagesDataSource.GetItems();

            this.NatureItems = new ObservableCollection<object>(items.Where(x => x.Category == "Nature"));
            this.AnimalItems = new ObservableCollection<object>(items.Where(x => x.Category == "Animal"));
            this.CityItems = new ObservableCollection<object>(items.Where(x => x.Category == "City"));
            this.MotorItems = new ObservableCollection<object>(items.Where(x => x.Category == "Motor"));
            //this.ItemTemplate = Resources["PhotoItemTemplate"] as DataTemplate;
        }
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
    