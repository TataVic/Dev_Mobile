namespace Aula3FlyoutPage;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void BtnPage1(object sender, EventArgs e)
    {
		//IMPORTANTE - cuidado convers�o de levar o menu junto
		//((FlyoutPage)App.Current.MainPage).Detail= new Page1();

        //altera��o para tirar os alertas
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage ( new Page1());

    }
    private void BtnPage2(object sender, EventArgs e)
    {
        //IMPORTANTE - cuidado convers�o de levar o menu junto
        //((FlyoutPage)App.Current.MainPage).Detail = new Page2();
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page2());


    }
    private void BtnPage3(object sender, EventArgs e)
    {
        //IMPORTANTE - cuidado convers�o de levar o menu junto
        //((FlyoutPage)App.Current.MainPage).Detail = new Page3();
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page3());


    }
}