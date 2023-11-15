using CommunityToolkit.Mvvm.Input;
using PowerQualityMonitor_NetMetering.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PowerQualityMonitor_NetMetering.ViewModels
{
    public partial class LoginViewModel: BaseViewModel
    {
     
        public ObservableCollection<LoginRequestModel> Login { get; set; } = new ();
        public LoginViewModel()
        {
            Title = "LoginPage";
        }

        [RelayCommand]
        async Task GotoSignup()
        {
            await Shell.Current.GoToAsync(state: "//SignupPage");
        }
        [RelayCommand]
        async Task loginUser(LoginRequestModel loginRequest)
        {
            //code to implement login 
            var data = loginRequest;


            Preferences.Set("UserAlreadyloggedIn", true);


            await Shell.Current.GoToAsync(state: "//DashboardPage");

        }







    }
}
