namespace MockExam.Models
{
    public class Rooms
    {
        public int RoomsId { get; set; }
        public string RoomName { get; set; } 
        public string Description { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public int MaxGuests { get; set; }
        public bool IsAvailable { get; set; }

        public ICollection<Bookings>? Bookings { get; set; } 
    }
}