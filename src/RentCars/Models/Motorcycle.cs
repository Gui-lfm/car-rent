using RentCars.Types;

namespace RentCars.Models;

public class Motorcycle : Vehicle
{
  public double SeatHeight { get; set; }
  public BrakeType FrontBrake { get; set; }
  public BrakeType RearBrake { get; set; }
}