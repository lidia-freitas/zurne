namespace GoogleDirections
{
  /// <summary>
  /// Class representing a location, defined by name and/or by latitude/longitude
  /// </summary>
  public class Location
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Location"/> class.
    /// </summary>
    /// <param name="locationName">Name of the location.</param>
    public Location(string locationName)
    {
      _locationName = locationName;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Location"/> class.
    /// </summary>
    /// <param name="latLng">The latitude/longitude of the location.</param>
    public Location(LatLng latLng)
    {
      _latLng = latLng;
    }

    internal Location(LatLng latLng, string locationName)
    {
      _latLng = latLng;
      _locationName = locationName;
    }

    private readonly LatLng _latLng;
    /// <summary>
    /// Gets the latitude/longitude of the location.
    /// </summary>
    public LatLng LatLng
    {
      get { return _latLng; }
    }

    private readonly string _locationName;
    /// <summary>
    /// Gets the name/address of the location.
    /// </summary>
    /// <value>
    /// The name/address of the location.
    /// </value>
    public string LocationName
    {
      get { return _locationName;  }
    }

    /// <summary>
    /// Returns a <see cref="System.String"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String"/> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      if (_locationName !=  null)
        return _locationName;

      return _latLng.ToString();
    }
  }
}
