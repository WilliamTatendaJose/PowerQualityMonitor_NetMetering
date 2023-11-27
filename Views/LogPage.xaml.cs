using PowerQualityMonitor_NetMetering.ViewModels;
namespace PowerQualityMonitor_NetMetering.Views;

public partial class LogPage : ContentPage
{
	public LogPage()
	{
		InitializeComponent();
		BindingContext = new LogsViewModel();
	}
}