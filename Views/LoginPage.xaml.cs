using PowerQualityMonitor_NetMetering.ViewModels;

namespace PowerQualityMonitor_NetMetering.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		
		BindingContext= new LoginViewModel(Navigation);
        InitializeComponent();

    }
}