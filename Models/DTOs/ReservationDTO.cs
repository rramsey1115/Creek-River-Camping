public class ReservationDTO
{
    public int Id { get; set; }
    public int CampsiteId { get; set; }
    public CampsiteDTO Campsite { get; set; }
    public int UserProfileId { get; set; }
    public UserProfileDTO UserProfile { get; set; }
    public DateTime CheckinDate { get; set; }
    public DateTime CheckoutDate { get; set; }
    public int TotalNights => (CheckoutDate - CheckinDate).Days;
    private static readonly decimal _reservationBaseFee = 10M;
    public decimal TotalCost
    {
        get
        {
            return Campsite.CampsiteType.FeePerNight * TotalNights + _reservationBaseFee;
        }
    }
}