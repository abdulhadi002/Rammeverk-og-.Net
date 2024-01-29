namespace Gruppe.net.Harbor.Dock
{
    public class DockSpace
    {
        private int dockSpaceNumber { get; set; }
        private DockSpaceType type { get; set; }
        private List<ShipType> allowedShipTypes { get; set; }

        public void configuraDockSpace() { }

        public void AddAllowedShipType(ShipType shipType)
        {
            allowedShipTypes.Add(shipType);
        }
    }
}
