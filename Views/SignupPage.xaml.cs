using PowerQualityMonitor_NetMetering.ViewModels;

namespace PowerQualityMonitor_NetMetering.Views;

public partial class SignupPage : ContentPage
{
	public SignupPage()
	{
		
		BindingContext = new SignUpViewModel();
        InitializeComponent();
    }
}