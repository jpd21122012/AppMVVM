﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using AppMVVM.Base;

namespace AppMVVM.ViewModels
{
    public class ExitViewModel: ViewModelBase
    {
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
