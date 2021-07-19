using AppUWP.Base;
using AppUWP.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppUWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UxView : PageBase
    {
        public UxView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            UxViewModel vm = this.DataContext as UxViewModel;
            vm.ItemTemplate = Resources["PhotoItemTemplate"] as DataTemplate;
            base.OnNavigatedTo(e);
        }
    }
}
