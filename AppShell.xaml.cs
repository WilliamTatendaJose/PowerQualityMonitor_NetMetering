using PowerQualityMonitor_NetMetering.Views;

namespace PowerQualityMonitor_NetMetering
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NHaF1cWWhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdEZiWHxecndQRmVUVUZwWg==");
           

            var getuserSavedkey = Preferences.Get("UserAlreadyloggedIn", false);

            if (getuserSavedkey == true)
            {


                MyAppShell.CurrentItem = MyDashboardPage;


            }
            else
            {
                MyAppShell.CurrentItem = MyLoginPage;

            }

            Routing.RegisterRoute(nameof(SignupPage), typeof(SignupPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(Settings), typeof(Settings));
            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
            Routing.RegisterRoute(nameof(LogPage), typeof(LogPage));
            Routing.RegisterRoute(nameof(ForgotPassword), typeof(ForgotPassword));
        }
    }
}
