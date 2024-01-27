using LoginPage.UserInterface;

namespace LoginPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPageUI();
        }
    }
}