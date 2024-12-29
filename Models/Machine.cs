namespace MachineParkManagement.Models
{
    public class Machine
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;// Online/Offline
        public string LastData { get; set; } = string.Empty;
    }
}



