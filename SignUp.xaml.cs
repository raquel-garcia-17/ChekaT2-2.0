namespace ChekaT2;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }

    private async void TapGestureRecognizer_Tapped_For_HomePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomePage");
    }
}