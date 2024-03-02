namespace Aula3FlyoutPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutPageMenu();
        }
    }
}
