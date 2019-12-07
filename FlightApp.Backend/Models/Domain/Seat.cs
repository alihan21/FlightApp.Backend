namespace FlightApp.Backend.Models.Domain
{
  public class Seat
  {
    public int SeatId { get; set; }
    public string SeatNumber { get; set; }

    public Seat(string seatNumber)
    {
      SeatNumber = seatNumber;
    }

    protected Seat()
    {

    }
  }
}
