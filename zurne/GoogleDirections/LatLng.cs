using System.Globalization;
using System.Xml;

namespace GoogleDirections
{
  /// <summary>
  /// Class representing a latitude/longitude pair
  /// </summary>
  public class LatLng
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="LatLng"/> class.
    /// </summary>
    /// <param name="latitude">The latitude.</param>
    /// <param name="longitude">The longitude.</param>
    public LatLng(double latitude, double longitude)
    {
      _latitude = latitude;
      _longitude = longitude;
    }

    internal LatLng(XmlElement locationElement)
    {
      _latitude = double.Parse(locationElement.SelectSingleNode("lat").InnerText, CultureInfo.InvariantCulture);
      _longitude = double.Parse(locationElement.SelectSingleNode("lng").InnerText, CultureInfo.InvariantCulture);
    }

    private readonly double _latitude;
    /// <summary>
    /// Gets the latitude.
    /// </summary>
    public double Latitude
    {
      get
      {
        return _latitude;
      }
    }

    private readonly double _longitude;
    /// <summary>
    /// Gets the longitude.
    /// </summary>
    public double Longitude
    {
      get
      {
        return _longitude;
      }
    }

    /// <summary>
    /// Returns a <see cref="System.String"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String"/> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      return _latitude.ToString() + ", " + _longitude.ToString();
    }
  }
}
