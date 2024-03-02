namespace Aula3NavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}
	private void Prossegue(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page3());
	}
    private void Voltar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
		//Navigation.PopToRootAsync(); //volta para a primeira direto
		//Navigation.RemovePage(); //remover a página
    }
}