namespace Gruppe.net.Harbor.Models
{
    public class ContainerHistory
    {
        private List<Location> locations {  get; set; } 
        public int getContainerHistory(int containerId) { return locations.Count; } 
    }
}
