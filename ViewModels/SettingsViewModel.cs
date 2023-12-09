using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using PowerQualityMonitor_NetMetering.Models;
using PowerQualityMonitor_NetMetering.Views;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQualityMonitor_NetMetering.ViewModels
{
    public partial class SettingsViewModel: BaseViewModel

    {
        private string webApiKey = "AIzaSyA3pj6EKCWmjtJN_LpVJd1MsmfSw9rWWKk";
        int count = 0;
        [ObservableProperty]
        public bool changeDeviceId;
        public UserModel User {  get; set; }
        [ObservableProperty]
        public string buttonText;
        public SettingsViewModel()
        {
            Title = "Settings";
            User = new UserModel();
            ButtonText = "Change Device";
            ChangeDeviceId = false;
        }

        [RelayCommand]
        static async Task SignOut()
        {
                try
                {

                    Preferences.Set("UserAlreadyloggedIn", false);
                    Application.Current.MainPage = new LoginPage();
                   // Preferences.Clear();

                    //await Shell.Current.GoToAsync(nameof(LoginPage));
            }
                catch (Exception ex)
                {
                    await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                    throw;
                }
            }


        [RelayCommand]
        async Task ChangeDevice()
        {
            count++;
            if(count== 1)
            {
                ChangeDeviceId = true;
                ButtonText = "Save Device Id";

            }

            if(count== 2)
            {
                if (User.DeviceId != null)
                {

                    await App.Current.MainPage.DisplayAlert("Success", "Device ID Saved", "OK");
                    ButtonText = "Change Device";
                    ChangeDeviceId = false;

                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Enter a valid Device ID", "OK");
                }
                count = 0;
            }

            
        }


    }

      
   }

