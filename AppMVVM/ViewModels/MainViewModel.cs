using AppMVVM.Base;
using System;
using AppMVVM.Base;
using AppMVVM.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace AppMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private bool _isMenuOpen;
        public bool IsMenuOpen
        {
            get { return _isMenuOpen; }
            set
            {
                _isMenuOpen = value;
                RaisePropertyChanged();
            }
        }

        private ICommand _openCloseMenuCommand;
        public ICommand OpenCloseMenuCommand
        {
            get { return _openCloseMenuCommand = _openCloseMenuCommand ?? new DelegateCommand(OpenCloseMenuExecute); }
        }
        private void OpenCloseMenuExecute()
        {
            IsMenuOpen = !IsMenuOpen;
        }

        private DelegateCommand<string> _navigationCommand;
        public DelegateCommand<string> NavigationCommand
        {
            get { return _navigationCommand = _navigationCommand ?? new DelegateCommand<string>(NavigationExecute); }
        }
        private void NavigationExecute(string viewFrame)
        {
            switch (viewFrame)
            {
                case "SecondView":
                    SplitViewFrame.Navigate(typeof(SecondView));
                    break;
                case "OtherView":
                    SplitViewFrame.Navigate(typeof(OtherView));
                    break;
            }
            IsMenuOpen = false;
        }
        public override Task OnNavigateFrom(NavigationEventArgs args)
        {
            return null;
        }

        public override Task OnNavigateTo(NavigationEventArgs args)
        {
            return null;
        }
    }
}