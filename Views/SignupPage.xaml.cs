using PowerQualityMonitor_NetMetering.ViewModels;

namespace PowerQualityMonitor_NetMetering.Views;

public partial class SignupPage : ContentPage
{
	public SignupPage()
	{
		InitializeComponent();
		BindingContext = new SignUpViewModel();
	}
}