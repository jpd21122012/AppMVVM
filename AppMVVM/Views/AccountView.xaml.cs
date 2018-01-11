using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AppMVVM.Base;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppMVVM.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AccountView : PageBase
    {
        public AccountView()
        {
            this.InitializeComponent();
            AccountFrame.Navigate(typeof(MainAccountView));
            AppBarToggleButtonAccount.IsChecked = true;
        }
        private void AppBarToggleButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var button = (AppBarToggleButton)sender;
            System.Diagnostics.Debug.WriteLine(button.Name);

            switch (button.Name)
            {
                case "AppBarToggleButtonAccount":
                    AppBarToggleButtonPrivacy.IsChecked = false;
                    AppBarToggleButtonPayment.IsChecked = false;
                    AppBarToggleButtonSecurity.IsChecked = false;
                    AppBarToggleButtonSubscription.IsChecked = false;
                    AccountFrame.Navigate(typeof(MainAccountView));
                    break;
                case "AppBarToggleButtonPrivacy":
                    AppBarToggleButtonAccount.IsChecked = false;
                    AppBarToggleButtonPayment.IsChecked = false;
                    AppBarToggleButtonSecurity.IsChecked = false;
                    AppBarToggleButtonSubscription.IsChecked = false;
                    AccountFrame.Navigate(typeof(AccountPrivacyView));
                    break;
                case "AppBarToggleButtonSecurity":
                    AppBarToggleButtonAccount.IsChecked = false;
                    AppBarToggleButtonPrivacy.IsChecked = false;
                    AppBarToggleButtonPayment.IsChecked = false;
                    AppBarToggleButtonSubscription.IsChecked = false;
                    AccountFrame.Navigate(typeof(AccountSecurityView));
                    break;
                case "AppBarToggleButtonPayment":
                    AppBarToggleButtonAccount.IsChecked = false;
                    AppBarToggleButtonPrivacy.IsChecked = false;
                    AppBarToggleButtonSecurity.IsChecked = false;
                    AppBarToggleButtonSubscription.IsChecked = false;
                    AccountFrame.Navigate(typeof(AccountPaymentView));
                    break;
                case "AppBarToggleButtonSubscription":
                    AppBarToggleButtonAccount.IsChecked = false;
                    AppBarToggleButtonPrivacy.IsChecked = false;
                    AppBarToggleButtonSecurity.IsChecked = false;
                    AppBarToggleButtonPayment.IsChecked = false;
                    AccountFrame.Navigate(typeof(AccountSubscriptionView));
                    break;
            }
        }
    }
}