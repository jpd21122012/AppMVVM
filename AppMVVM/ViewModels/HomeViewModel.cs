using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Navigation;
using AppMVVM.Base;
using AppMVVM.Views;

namespace AppMVVM.ViewModels
{
    public class HomeViewModel: ViewModelBase
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
                case "Login":
                    SplitViewFrame.Navigate(typeof(LoginView));
                    break;
                case "Recognizer":
                    SplitViewFrame.Navigate(typeof(MainPageView));
                    break;
                case "Account":
                    SplitViewFrame.Navigate(typeof(AccountView));
                    break;
                case "Exit":
                    //Method to put 0 on db
                    SplitViewFrame.Navigate(typeof(ExitView));
                    break;
            }
            IsMenuOpen = false;
        }
        public override Task OnNavigateTo(NavigationEventArgs args)
        {
            return null;
        }

        public override Task OnNavigateFrom(NavigationEventArgs args)
        {
            return null;
        }
    }
}
