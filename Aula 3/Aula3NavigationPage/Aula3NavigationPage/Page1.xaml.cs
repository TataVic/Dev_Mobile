namespace Aula3NavigationPage;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

	private void Prossegue(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page2());
	}
}