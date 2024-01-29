namespace Gruppe.net.Harbor.Models
{
    public class SailingSchedule
    {
        private List<TimeSlot> availableTimes {  get; set; }
        private List<SingleSailing> singleSailings { get; set; }
        private List<RecurringSailing> recurringSailing { get; set; }


    }
}
