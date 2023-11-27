using CommunityToolkit.Mvvm.Input;
using PowerQualityMonitor_NetMetering.Models;
using PowerQualityMonitor_NetMetering.Views;
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
     
            
        public LoginRequestModel login { get; set; }
        public LoginViewModel()
        {
            Title = "Welcome";
        }

        [RelayCommand]
        async Task GotoSignup()
        {
            await Shell.Current.GoToAsync(nameof(SignupPage));
        }
        [RelayCommand]
        async Task ForgotPassword()
        {
            await Shell.Current.GoToAsync(nameof(ForgotPassword));
        }
        [RelayCommand]
        public async Task LoginUser(LoginRequestModel loginRequest)
        {
            //code to implement login 
            var data = loginRequest;


            Preferences.Set("UserAlreadyloggedIn", true);
            Application.Current.MainPage = new AppShell();



            await Shell.Current.GoToAsync(state: "//DashboardPage");

        }







    }
}
