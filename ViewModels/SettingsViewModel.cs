using CommunityToolkit.Mvvm.Input;
using PowerQualityMonitor_NetMetering.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQualityMonitor_NetMetering.ViewModels
{
    public partial class SettingsViewModel: BaseViewModel
    {
        public SettingsViewModel()
        {
            Title = "Settings";
        }

        [RelayCommand]
        async Task SignOut()
        {
            Preferences.Clear();

            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        [RelayCommand]
        async Task ChangeDevice()
        {

        }
    }
}
