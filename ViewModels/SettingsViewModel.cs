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
        [ObservableProperty]
        public  string serialNum;
        
        [ObservableProperty]
        public bool changeDeviceId;
       
        [ObservableProperty]
        public string buttonText;
        public UserModel UserModel { get; set; }

        int count = 0;
        public SettingsViewModel()
        {
            Title = "Settings";
            ButtonText = "Change Device";
            ChangeDeviceId = false;
            UserModel = new()
            {
                DeviceId = "12569HD1"
            };
            SerialNum = "Serial Num:" + UserModel.DeviceId;
        }

        [RelayCommand]
        static async Task SignOut()
        {
                try
                {

                    Preferences.Set("UserAlreadyloggedIn", false);
                    Application.Current.MainPage = new LoginPage();
                    Preferences.Clear();

                    
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
                if (UserModel.DeviceId != null)
                {

                    await App.Current.MainPage.DisplayAlert("Success", "Device ID Saved", "OK");
                    SerialNum = "Serial Num:" + UserModel.DeviceId;
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

