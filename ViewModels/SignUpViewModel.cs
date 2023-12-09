using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using PowerQualityMonitor_NetMetering.Models;
using PowerQualityMonitor_NetMetering.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQualityMonitor_NetMetering.ViewModels
{
    partial class SignUpViewModel : BaseViewModel
    {
        public UserModel RegisterUser { get; set; }

        private string webApiKey = "AIzaSyA3pj6EKCWmjtJN_LpVJd1MsmfSw9rWWKk";
        private INavigation Navigation {  get; set; }

        public SignUpViewModel()
        {
            
        }

        public SignUpViewModel(INavigation navigation)
        {
            Navigation = navigation;

            Title = "Register";
            RegisterUser = new UserModel();
        }

        [RelayCommand]
        public async Task RegisterNewUser(UserModel registerUser)
        {
            if(RegisterUser.Password != RegisterUser.ConfirmPassword)
            {

                await App.Current.MainPage.DisplayAlert("Alert", "Passwords do not match", "OK");
            }
            else if (RegisterUser.Email is null|| RegisterUser.Password is null || RegisterUser.ConfirmPassword is null)
            {
                await App.Current.MainPage.DisplayAlert("Alert","Please fill in all details ", "OK");
            }
            else
            {
                try
                {
                    IsBusy = true;
                    var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
                    var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(RegisterUser.Email, RegisterUser.Password);
                    string token = auth.FirebaseToken;
                    if (token != null)
                        IsBusy = false;
                        await App.Current.MainPage.DisplayAlert("Alert", "User Registered successfully", "OK");
                    await Navigation.PopAsync();

                }
                catch (Exception ex)
                {
                    IsBusy = false;
                    await App.Current.MainPage.DisplayAlert("Alert", "Failed to register please try again later", "OK");
                    
                }

            }
           
        }
    }
}
