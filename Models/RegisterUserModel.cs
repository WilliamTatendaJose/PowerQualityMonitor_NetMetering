using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQualityMonitor_NetMetering.Models
{
    public  class RegisterUserModel
    {
         public  string Password { get; set;}
         public string ConfirmPassword { get; set;}
         public string Email { get; set;}

    }
}
