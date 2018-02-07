using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using AppMVVM.Base;

namespace AppMVVM.Views
{
    public sealed partial class HomeView : PageBase
    {
        public HomeView()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            base.SplitViewFrame = splitViewFrame;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) => HomeImage.Visibility = Visibility.Collapsed;
    }
}