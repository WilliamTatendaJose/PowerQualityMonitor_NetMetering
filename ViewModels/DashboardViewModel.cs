using CommunityToolkit.Mvvm.Input;
using PowerQualityMonitor_NetMetering.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQualityMonitor_NetMetering.ViewModels
{
    partial  class DashboardViewModel : BaseViewModel
    {   
        public DashboardViewModel() 
        {
            Title = "Home";
        }

        [RelayCommand]
        async Task SignOut()
        {
            Preferences.Clear();

            await Shell.Current.GoToAsync(nameof(LoginPage));
        }


    }
}
