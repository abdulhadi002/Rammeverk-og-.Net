using System.Security.AccessControl;

namespace Gruppe.net.Harbor.Models
{
    public class SecurityRegulations
    {
        private AccessControlActions accessControl { get; set; }
        private List<ShipCertificate> shipCertificates { get; set; }
        private List<Inspection> inspectionHistory { get; set; }
    }
}
