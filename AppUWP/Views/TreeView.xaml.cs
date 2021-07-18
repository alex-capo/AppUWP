namespace AppUWP.Views
{
    using AppUWP.Base;
    using AppUWP.Models;
    using AppUWP.ViewModels;
    using Windows.UI.Xaml.Navigation;
    public sealed partial class TreeView : PageBase
    {
        readonly TreeViewModel vm;
        public TreeView()
        {
            this.InitializeComponent();
            vm = this.DataContext as TreeViewModel;
        }

        private void TreeView_Expanding(Microsoft.UI.Xaml.Controls.TreeView sender, Microsoft.UI.Xaml.Controls.TreeViewExpandingEventArgs args)
        {
            ((ItemTreeView)args.Item).IsExpanded = args.Node.IsExpanded;
            vm.SaveSelection();
        }

        private void TreeView_Collapsed(Microsoft.UI.Xaml.Controls.TreeView sender, Microsoft.UI.Xaml.Controls.TreeViewCollapsedEventArgs args)
        {
            ((ItemTreeView)args.Item).IsExpanded = args.Node.IsExpanded;
            vm.SaveSelection();
        }
    }
}
