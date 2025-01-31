namespace Cloudweather.DataLoader.Models;

public class PrecipitationModel
{
  public DateTime CreatedOn { get; set; }
  public decimal AmountInches { get; set; }
  public string WeatherType { get; set; } = string.Empty;
  public string ZipCode { get; set; } = string.Empty;
}
