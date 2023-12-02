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
    partial class SignUpViewModel: BaseViewModel

    {
        private UserModel RegisterUser { get; set; }
        private readonly FirebaseAuthClient _authClient;
        public SignUpViewModel()
        {
            Title = "Register";
            
        }

        [RelayCommand]
        public async Task RegisterNewUser(UserModel registerUser, FirebaseAuthClient _authClient)

        {

            if (registerUser.Password != registerUser.ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Password and confirm password values do not match.", "Ok");
                return;
            }

            try
            {
                await _authClient.CreateUserWithEmailAndPasswordAsync(registerUser.Email, registerUser.Password);

                await Application.Current.MainPage.DisplayAlert("Success", "Successfully signed up!", "Ok");

                await Shell.Current.GoToAsync(nameof(LoginPage));
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Failed to sign up. Please try again later.", "Ok");
            }

        }
    }
}
