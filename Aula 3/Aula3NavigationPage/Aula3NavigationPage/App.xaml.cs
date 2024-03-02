namespace Aula3NavigationPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new NovaPagina();
            MainPage = new NavigationPage (new Page1());
        }
    }
}
