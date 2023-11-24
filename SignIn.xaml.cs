namespace ChekaT2;

public partial class SignIn : ContentPage
{
	public SignIn()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");
    }

    private async void TapGestureRecognizer_Tapped_For_HomePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomePage");
    }

}