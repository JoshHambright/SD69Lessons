using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_Challenge_Interfaces.Vehicles
{
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        string Color { get; }

     

        string Start();
        string TurnOff();

        string Drive();

    }
}
