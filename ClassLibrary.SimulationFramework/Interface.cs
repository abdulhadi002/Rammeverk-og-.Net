using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.SimulationFramework
{
    internal interface Interface
    {
        /// <summary>
        /// Runs this simulation to calculate time needed to travel from Sarpsborg to Halden.
        /// </summary>
        /// <param name="distance">The distance in KM.</param>
        /// <param name="acceleration"> The acceleration in m/s^2</param>
        /// <return>The number of seconds taken to travel the distance.</return>

        public int Run(int distance, float acceleration);
    }
}
