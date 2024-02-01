using Gruppe.net.Harbor.Models;

namespace Gruppe.net.Harbor.Models
{
    public enum ShipType
    {
        CARGO_SHIP,
        CRUISE_SHIP,
        LEISURE_BOAT
    }

    public class ShipSpeeds
    {
        public static int GetSpeed(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.CARGO_SHIP:
                    return "shipSpeed" = 20; 
                case ShipType.CRUISE_SHIP:
                    return "shipSpeed" = 30; 
                case ShipType.LEISURE_BOAT:
                    return "shipSpeed" = 50;
                default:
                    return null;
            }
        }
    }
}