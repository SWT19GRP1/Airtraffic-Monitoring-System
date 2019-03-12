using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace Airtraffic_Monitoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var reciever = TransponderReceiverFactory.CreateTransponderDataReceiver();
            var trackfilter = new TrackFilter(reciever);
            while (true)
            {

            }
        }
    }
}
