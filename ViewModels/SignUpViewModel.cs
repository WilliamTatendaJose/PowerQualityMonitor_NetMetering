using CommunityToolkit.Mvvm.Input;
using PowerQualityMonitor_NetMetering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQualityMonitor_NetMetering.ViewModels
{
    partial class SignUpViewModel: BaseViewModel
    {
        public RegisterUserModel RegisterUser { get; set; }
        public SignUpViewModel()
        {
            Title = "Register";
        }

        [RelayCommand]
        async Task RegisterNewUser(RegisterUserModel registerUser)
        {


        }
    }
}
