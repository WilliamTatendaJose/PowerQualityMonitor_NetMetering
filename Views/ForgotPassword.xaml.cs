using PowerQualityMonitor_NetMetering.ViewModels;
namespace PowerQualityMonitor_NetMetering.Views;

public partial class ForgotPassword : ContentPage
{
	public ForgotPassword()
	{
		
		BindingContext = new ForgotPasswordViewModel(Navigation);
        InitializeComponent();
    }
}