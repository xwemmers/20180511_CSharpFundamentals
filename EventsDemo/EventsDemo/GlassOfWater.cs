using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class GlassOfWater
    {
        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;

                // Raise event!
                // (Of fire event)
                // en geef de nieuwe temperatuur als parameter mee
                // Die parameter is gedefinieerd door de delegate

                TemperatureChanged?.Invoke(DateTime.Now);

                // Let er bij het afvuren van de event op dat
                // de event 'leeg' kan zijn. Vandaar de Elvis operator!
                // Dat de event 'leeg' is houdt in dat er niemand naar
                // de event staat te luisteren

                if (value >= 100)
                    WaterBoiling?.Invoke(DateTime.Now);

                if (value <= 0)
                    WaterFreezing?.Invoke(DateTime.Now);

                if (value > 0 && value < 100)
                    WaterNormal?.Invoke(DateTime.Now);
            }
        }

        public delegate void TemperatureChangedEventHandler(DateTime when);

        public event TemperatureChangedEventHandler TemperatureChanged;
        public event TemperatureChangedEventHandler WaterBoiling;
        public event TemperatureChangedEventHandler WaterFreezing;

        // Maar in plaats van een delegate mag je ook
        // de meer moderne Action gebruiken:
        public event Action<DateTime> WaterNormal;
    }
}
