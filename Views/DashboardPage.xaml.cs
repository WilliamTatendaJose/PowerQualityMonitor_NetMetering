using PowerQualityMonitor_NetMetering.ViewModels;

namespace PowerQualityMonitor_NetMetering.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();	
	}
}