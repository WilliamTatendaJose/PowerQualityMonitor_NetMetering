using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Microsoft.Maui.Controls;
using PowerQualityMonitor_NetMetering.Models;
using PowerQualityMonitor_NetMetering.Views;

namespace PowerQualityMonitor_NetMetering.ViewModels
{
    public partial class ForgotPasswordViewModel: BaseViewModel
    {
        public UserModel User { get; set; }
        public INavigation Navigation { get; set; }


        private string webApiKey = "AIzaSyA3pj6EKCWmjtJN_LpVJd1MsmfSw9rWWKk";
       
        public ForgotPasswordViewModel(INavigation navigation)
        {
            Navigation = navigation;

            User = new UserModel();
            Title = "Forgot Password?";
        }

        [RelayCommand]
        async Task ResetPassword()
        {
            // code to reset password
            
            await App.Current.MainPage.DisplayAlert("Alert", "Check your email to reset your password", "OK");
            await Navigation.PopAsync();
        }


    }
}
