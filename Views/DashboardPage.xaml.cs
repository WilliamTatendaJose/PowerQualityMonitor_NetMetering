using PowerQualityMonitor_NetMetering.ViewModels;

namespace PowerQualityMonitor_NetMetering.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		
		BindingContext = new DashboardViewModel();
        InitializeComponent();
    }
}