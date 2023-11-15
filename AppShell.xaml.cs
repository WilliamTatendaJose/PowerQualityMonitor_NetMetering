using PowerQualityMonitor_NetMetering.Views;

namespace PowerQualityMonitor_NetMetering
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            var getuserSavedkey = Preferences.Get("UserAlreadyloggedIn", false);

            if (getuserSavedkey == true)
            {
                MyAppShell.CurrentItem = MyDashboardPage;

            }
            else
            {
                MyAppShell.CurrentItem = MyLoginPage;

            }
        }
    }
}
