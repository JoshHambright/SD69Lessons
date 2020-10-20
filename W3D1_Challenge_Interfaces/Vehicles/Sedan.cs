using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_Challenge_Interfaces.Vehicles
{
    public class Sedan : IVehicle
    {
        private bool _isOn = false;
        private bool _doorsClosed = false;
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public bool IsOn { get; set; }

        private bool DoorsClosed { get; set; }
        public string Start()
        {
            if (_isOn == true)
            {
                return "Vehicle already turned on";
            }
            else
            {
                _isOn = true;
                return "Vehicle turned on";
            }
        }

        public string TurnOff()
        {
            if (_isOn == false)
            {
                return "Vehicle is already Off";
            }
            else
            {
                _isOn = false;
                return "Vehicle turned off";
            }
        }

        public string Drive()
        {
            if (_isOn == true && _doorsClosed == true)
            {
                return "Vroom!";
            }

            else { return "Vehicle not ready to drive."; }
        }

        public string CloseDoors()
        {
            if(_doorsClosed == false)
            {
                _doorsClosed = true;
                return "Doors Closed!";
            }
            else { return "Doors already closed!"; }
        }

        public string OpenDoors()
        {
            if (_doorsClosed == true)
            {
                _doorsClosed = false;
                return "Doors Opened";
            }
            else { return "Doors are already Open!"; }
        }

    }
}
