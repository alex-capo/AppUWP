using AppUWP.ViewModels;
using Unity;

namespace AppUWP.Base
{
    public class Locator
    {
        private readonly IUnityContainer _container;

        public Locator()
        {
            _container = new UnityContainer();
            _container.RegisterType<MainViewModel>();
            _container.RegisterType<TreeViewModel>();
            _container.RegisterType<PdfViewModel>();
            _container.RegisterType<UxViewModel>();
        }

        public MainViewModel MainViewModel => _container.Resolve<MainViewModel>();
        public TreeViewModel TreeViewModel => _container.Resolve<TreeViewModel>();
        public PdfViewModel PdfViewModel => _container.Resolve<PdfViewModel>();
        public UxViewModel UxViewModel => _container.Resolve<UxViewModel>();
    }
}
