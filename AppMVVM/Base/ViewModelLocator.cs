using AppMVVM.ViewModels;
using Microsoft.Practices.Unity;

namespace AppMVVM.Base
{
    public class ViewModelLocator
    {
        private readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();

            _container.RegisterType<MainViewModel>();
            _container.RegisterType<SecondViewModel>();
            _container.RegisterType<OtherViewModel>();
            _container.RegisterType<HomeViewModel>();
            _container.RegisterType<LoginViewModel>();
            _container.RegisterType<MainPageViewModel>();
            _container.RegisterType<AccountViewModel>();
            _container.RegisterType<ExitViewModel>();
            _container.RegisterType<AboutViewModel>();
            _container.RegisterType<MainAccountViewModel>();
            _container.RegisterType<AccountPaymentViewModel>();
            _container.RegisterType<AccountPrivacyViewModel>();
            _container.RegisterType<AccountSecurityViewModel>();
            _container.RegisterType<AccountSubscriptionViewModel>();
        }

        public MainViewModel MainViewModel => _container.Resolve<MainViewModel>();
        public SecondViewModel SecondViewModel => _container.Resolve<SecondViewModel>();
        public OtherViewModel OtherViewModel => _container.Resolve<OtherViewModel>();
        public HomeViewModel HomeViewModel => _container.Resolve<HomeViewModel>();
        public LoginViewModel LoginViewModel => _container.Resolve<LoginViewModel>();
        public MainPageViewModel MainPageViewModel => _container.Resolve<MainPageViewModel>();
        public AccountViewModel AccountViewModel => _container.Resolve<AccountViewModel>();
        public ExitViewModel ExitViewModel => _container.Resolve<ExitViewModel>();
        public AboutViewModel AboutViewModel => _container.Resolve<AboutViewModel>();
        public MainAccountViewModel MainAccountViewModel => _container.Resolve<MainAccountViewModel>();
        public AccountPaymentViewModel AccountPaymentViewModel => _container.Resolve<AccountPaymentViewModel>();
        public AccountPrivacyViewModel AccountPrivacyViewModel => _container.Resolve<AccountPrivacyViewModel>();
        public AccountSecurityViewModel AccountSecurityViewModel => _container.Resolve<AccountSecurityViewModel>();
        public AccountSubscriptionViewModel AccountSubscriptionViewModel => _container.Resolve<AccountSubscriptionViewModel>();
    }
}
