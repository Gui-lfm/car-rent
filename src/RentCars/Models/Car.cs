using RentCars.Types;
namespace RentCars.Models;

public class Car : Vehicle
{
  public int Seats { get; set; }
  public int Doors { get; set; }
  public TractionType Traction { get; set; }
  public BrakeType FrontBrake { get; set; }
  public BrakeType RearBrake { get; set; }
}