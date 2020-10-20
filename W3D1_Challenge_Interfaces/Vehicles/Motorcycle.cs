using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_Challenge_Interfaces.Vehicles
{
    class Motorcycle
    {
        private bool _isOn = false;
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }



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
            if (_isOn == true )
            {
                return "Vroom!";
            }

            else { return "Vehicle not ready to drive."; }
        }


    }
}
