namespace MauiAppEvento.Views;

public partial class Eventocontratado : ContentPage
{
	public Eventocontratado()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }
}