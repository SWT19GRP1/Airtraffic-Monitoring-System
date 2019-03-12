using System.Collections.Generic;

namespace Airtraffic_Monitoring_System.Interfaces
{
    interface IOutput
    {
        IVehicleFormatter Formatter { get; set; }
        void LogVehicleData(List<IVehicle> v);
    }
}
