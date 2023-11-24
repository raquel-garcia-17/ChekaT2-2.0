namespace ChekaT2;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }
}