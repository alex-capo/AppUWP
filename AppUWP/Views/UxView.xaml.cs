using AppUWP.Base;
using AppUWP.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppUWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UxView : PageBase
    {

        //#region ItemTemplate
        //public DataTemplate ItemTemplate
        //{
        //    get { return (DataTemplate)GetValue(ItemTemplateProperty); }
        //    set { SetValue(ItemTemplateProperty, value); }
        //}

        //public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), typeof(UxView), new PropertyMetadata(null));
        //#endregion

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
