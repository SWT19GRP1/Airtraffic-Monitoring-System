﻿using System;
using System.Collections.Generic;

namespace Airtraffic_Monitoring_System.Interfaces
{
    interface IATM_Separation_Condition
    {
        event EventHandler<SeparationConditionEventArgs> SeparationConditionEvent;
        void UpdateSeparationDetection(List<IVehicle> vehicles);
        bool SeparationDetection(IVehicle vehicleA, IVehicle vehicleB);
    }

    public class SeparationConditionEventArgs : EventArgs
    {
        public IVehicle[] vehicles { get; private set; }
        public SeparationConditionEventArgs(IVehicle[] Vehicles)
        {
            vehicles = Vehicles;
        }
    }
}
