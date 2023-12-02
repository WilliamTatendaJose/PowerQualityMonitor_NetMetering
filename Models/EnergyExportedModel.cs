using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerQualityMonitor_NetMetering.Models
{
   public class EnergyExportedModel
    {
        public double Energy {  get; set; }
        public string Year { get; set; }
        public string Month {  get; set; }
        public string Week { get; set; }    
        
        public string Day { get; set; }
    }
}
