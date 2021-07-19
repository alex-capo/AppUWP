
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppUWP.Views
{
    using AppUWP.Base;
    using AppUWP.ViewModels;
    using Microsoft.UI.Xaml.Controls;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainView : PageBase
    {
        readonly MainViewModel vm;
        public MainView()
        {
            this.InitializeComponent();
            base.MenuFrame = menuFrame;
            vm = this.DataContext as MainViewModel;
        }       

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            NavigationViewItemBase item = args.InvokedItemContainer as NavigationViewItemBase;
            vm?.Navigate(item.Tag.ToString());
        }
    }
}
