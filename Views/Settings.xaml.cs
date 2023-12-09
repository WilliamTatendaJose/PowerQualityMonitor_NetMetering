using PowerQualityMonitor_NetMetering.ViewModels;

namespace PowerQualityMonitor_NetMetering.Views;

public partial class Settings : ContentPage
{
	public Settings()
	{
		
		BindingContext = new SettingsViewModel();
        InitializeComponent();
    }
}