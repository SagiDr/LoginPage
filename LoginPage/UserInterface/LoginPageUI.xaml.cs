namespace LoginPage.UserInterface;

public partial class LoginPageUI : ContentPage
{
	public LoginPageUI()
	{
		InitializeComponent();
        this.BindingContext = new LoginPageUI();
    }
}