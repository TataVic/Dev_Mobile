namespace Aula3NavigationPage;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
    private void Voltar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}