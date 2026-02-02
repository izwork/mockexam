namespace MockExam.Models
{
    public class Bookings
    {
        public int BookingsId { get; set; }
        public int RoomsId { get; set; }

        public string BookingName { get; set; }
        public string Description { get; set; }
        public int GuestCount { get; set; }
        public bool HasPayed { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime BookingTime { get; set; }

        // Navigation property
        public Rooms Room { get; set; }

    }
}
