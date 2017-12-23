using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AppMVVM.Base
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
        private Frame _appFrame;
        public Frame AppFrame => _appFrame;

        public abstract Task OnNavigateTo(NavigationEventArgs args);
        public abstract Task OnNavigateFrom(NavigationEventArgs args);

        internal void SetAppFrame(Frame viewFrame)
        {
            _appFrame = viewFrame;
        }

    }
}
