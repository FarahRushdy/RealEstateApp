using PropertyApp.View;

namespace PropertyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Landing());
        }
    }
}
