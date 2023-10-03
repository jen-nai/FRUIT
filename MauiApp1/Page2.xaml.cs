namespace MauiApp1;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

	private void TapGestureRecognizer_Tapped(object senter, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}