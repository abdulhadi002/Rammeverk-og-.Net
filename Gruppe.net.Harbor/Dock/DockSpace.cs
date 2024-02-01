namespace Gruppe.net.Harbor.Models
{
    public class DockSpace
    {
        private int dockSpaceNumber { get; set; }
        private DockSpaceType type { get; set; }
        private List<ShipType> allowedShipTypes { get; set; }

        public void configuraDockSpace() { }
    }
}
