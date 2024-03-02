namespace mauiapp;

public partial class pag : ContentPage
{
	public pag()
	{
		InitializeComponent();
	}

	private void Clique(object sender, EventArgs e)
	{
		Random numero = new Random();
		txtnumber.Text = numero.Next(0,10000).ToString();
	}
}