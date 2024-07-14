namespace barberProject_Backend.Models
{
    public class ReservationServiceModel
    {
        public int ReservationId { get; set; }
        public int ServiceId { get; set; }

        public ReservationModel Reservation { get; set; }
        public ServiceModel Service { get; set; }
    }
}
