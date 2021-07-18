using AppUWP.Base;
using AppUWP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace AppUWP.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

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
            return null;
        }

        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            return null;
        }

    }
}
