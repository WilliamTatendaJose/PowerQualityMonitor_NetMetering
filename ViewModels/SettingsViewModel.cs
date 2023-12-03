using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using PowerQualityMonitor_NetMetering.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQualityMonitor_NetMetering.ViewModels
{
    public partial class SettingsViewModel: BaseViewModel

    {
        private string webApiKey = "AIzaSyA3pj6EKCWmjtJN_LpVJd1MsmfSw9rWWKk";
        public SettingsViewModel()
        {
            Title = "Settings";
        }

        [RelayCommand]
        async Task SignOut()
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

        }


    }

      
   }

