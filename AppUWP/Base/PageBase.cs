using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AppUWP.Base
{
    public class PageBase : Page
    {
        private ViewModelBase _viewModelBase;

        private Frame _menuFrame;
        public Frame MenuFrame
        {
            get => _menuFrame;
            set 
            { 
                _menuFrame = value;
                if (_viewModelBase == null)
                    _viewModelBase = (ViewModelBase)this.DataContext;
                _viewModelBase.SetMenuFrame(_menuFrame);
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _viewModelBase = (ViewModelBase)this.DataContext;
            _viewModelBase.SetAppFrame(this.Frame);
            _viewModelBase.OnNavigatedTo(e);

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            _viewModelBase.OnNavigatedFrom(e);
        }
    }
}
