using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;

using Microsoft.Maui.Controls;
using Newtonsoft.Json;
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
    public partial class LoginViewModel : BaseViewModel
    {
        public UserModel Login { get; set; }
        public INavigation Navigation { get; }

        
        private string webApiKey ="AIzaSyA3pj6EKCWmjtJN_LpVJd1MsmfSw9rWWKk";

       
        public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Title = "Welcome";
            Login = new UserModel();
        }

        [RelayCommand]
        async Task GotoSignup()
        {
            
                await Navigation.PushAsync(new SignupPage());

           
        }

        [RelayCommand]
        async Task GotoForgotPassword()
        {
            await Navigation.PushAsync(new ForgotPassword());
        }

        [RelayCommand]
        public async Task LoginUser()
        {
            if (Login.Email is null || Login.Password is null)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Please Fill in all details", "OK");
            }
            else
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
                try
                {
                    IsBusy= true;
                    var auth = await authProvider.SignInWithEmailAndPasswordAsync(Login.Email, Login.Password);
                    var content = await auth.GetFreshAuthAsync();
                    var serializedContent = JsonConvert.SerializeObject(content);
                    Preferences.Set("FreshFirebaseToken", serializedContent);
                    Preferences.Set("UserAlreadyloggedIn", true);
                    
                    if (serializedContent != null)
                        Application.Current.MainPage = new AppShell();
                    IsBusy= false;
                    await Shell.Current.GoToAsync(state: "//DashboardPage");

                }
                catch (Exception ex)
                {
                    IsBusy= false;
                    await App.Current.MainPage.DisplayAlert("Alert", "Failed to Log In try again later", "OK");

                }
            }
           

           


        }
    }
}
