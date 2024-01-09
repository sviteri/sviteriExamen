using sviteriExamen.Views;

namespace sviteriExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }
    }
}