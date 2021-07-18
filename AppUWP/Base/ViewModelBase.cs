namespace AppUWP.Base
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        private Frame _appFrame;

        public Frame AppFrame
        {
            get => _appFrame; 
            set { _appFrame = value; }
        }

        private Frame _menuFrame;

        public Frame MenuFrame
        {
            get => _menuFrame;
            set { _menuFrame = value; }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                //SetProperty(ref _isBusy, value);
                RaisePropertyChanged();
            }
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public abstract Task OnNavigatedTo(NavigationEventArgs args);

        public abstract Task OnNavigatedFrom(NavigationEventArgs args);

        internal void SetAppFrame(Frame viewFrame)
        {
            _appFrame = viewFrame;
        }

        internal void SetMenuFrame(Frame viewFrame)
        {
            _menuFrame = viewFrame;
        }
    }
}
