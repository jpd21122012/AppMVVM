using AppMVVM.Base;
using System;
using AppMVVM.Base;
using AppMVVM.Views;
using System.Threading.Tasks;
using System.Windows.Input;
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
        private string _holamundo;
        public string HolaMundo
        {
            get
            {
                return _holamundo;
            }
            set
            {
                _holamundo = value;
                RaisePropertyChanged();
            }
        }
        public override Task OnNavigateFrom(NavigationEventArgs args)
        {
            return null;
        }

        public override Task OnNavigateTo(NavigationEventArgs args)
        {
            HolaMundo = "Hello World from ViewModel";
            return null;
        }
    }
}