namespace Gruppe.net.Harbor.ContainerYard
{
    public class ContainerHistory
    {
        private List<Location> locations {  get; set; } 
        public int getContainerHistory(int containerId) { return locations.Count; } 
    }
}
