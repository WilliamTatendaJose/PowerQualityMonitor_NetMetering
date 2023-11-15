using PowerQualityMonitor_NetMetering.ViewModels;

namespace PowerQualityMonitor_NetMetering.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}
}