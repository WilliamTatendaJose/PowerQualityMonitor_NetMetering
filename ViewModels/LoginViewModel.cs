using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
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
     
            
        private UserModel Login { get; set; }
        private readonly FirebaseAuthClient _authClient;
       
        public LoginViewModel()
        {
            Title = "Welcome";
        }

        [RelayCommand]
        async Task GotoSignup()
        {
            if (Shell.Current != null)
            {
                
                await Shell.Current.GoToAsync(nameof(SignupPage));
            }
            else
            {
                Console.WriteLine("Shell.Current is null");
            }

        }

        [RelayCommand]
        async Task GotoForgotPassword()
        {
            if (Shell.Current != null)
            {
               
                await Shell.Current.GoToAsync("ForgotPassword") ;
            }
            else
            {
                Console.WriteLine("Shell.Current is null");
            }

        }
        [RelayCommand]
        public async Task LoginUser(UserModel Login, FirebaseAuthClient authClient)
        {
            //code to implement login 
            


            Preferences.Set("UserAlreadyloggedIn", true);
            Application.Current.MainPage = new AppShell();



            await Shell.Current.GoToAsync(state: "//DashboardPage");

        }







    }
}
