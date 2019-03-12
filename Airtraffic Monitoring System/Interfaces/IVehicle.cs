﻿using System;

namespace Airtraffic_Monitoring_System.Interfaces
{
    public interface IVehicle
    {
        int Y { get; }
        int X { get; }
        int Z { get; }
        DateTime Timestamp { get; }
        string Tag { get; }
        double Speed { get; }
        int Direction { get; }
        void Update(IVehicle old);
    }
}
