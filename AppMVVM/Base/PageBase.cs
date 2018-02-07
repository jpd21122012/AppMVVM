using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AppMVVM.Base
{
    public class PageBase : Page
    {
        private ViewModelBase _viewModel;
        private Frame _splitViewFrame;

        public Frame SplitViewFrame
        {
            get { return _splitViewFrame; }
            set
            {
                _splitViewFrame = value;
                if (_viewModel == null)
                {
                    _viewModel = (ViewModelBase)DataContext;
                }
                _viewModel.SetSplitViewFrame(_splitViewFrame);
            }
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _viewModel = (ViewModelBase)this.DataContext;
            _viewModel.SetAppFrame(this.Frame);
            _viewModel.OnNavigateTo(e);
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = Windows.UI.Core.AppViewBackButtonVisibility.Visible;
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += PageBase_BackRequested;
        }

        private void PageBase_BackRequested(object sender, Windows.UI.Core.BackRequestedEventArgs e)
        {
            if (Frame != null)
            {
                if (!Frame.CanGoBack) return;
                e.Handled = true;
                Frame.GoBack();
            }
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            _viewModel.OnNavigateFrom(e);
        }
    }
}
