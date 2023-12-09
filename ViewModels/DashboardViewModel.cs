using CommunityToolkit.Mvvm.Input;
using PowerQualityMonitor_NetMetering.Models;
using PowerQualityMonitor_NetMetering.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQualityMonitor_NetMetering.ViewModels
{
    partial  class DashboardViewModel : BaseViewModel
    {
        public List<EnergyExportedModel> Data { get; set;  }
        public DashboardViewModel() 
        {
            Title = "Home";
            Data =
            [
                new (){ Day="Sunday", Energy=1.234},
                new(){ Day="Monday", Energy=0.934},
                new(){ Day="Tuesday", Energy=1.000},
                new() { Day="Wednesday", Energy=1.134},
                new (){ Day="Thursday", Energy=1.234},
                new (){ Day="Friday", Energy=1.324},
                new() { Day = "Saturday", Energy = 0.7334 }

            ];
        }

       


    }
}
