/// <summary>
///  Simple barometer, measuring pressure in hPa (hectopascal)
/// </summary>
public class Barometer
{
    #region Properties
    public double Pressure { get; set; }

    public string WeatherDescription
    {
       get {
            if (Pressure < 980)
            {
                return "Stormy";
            }
            else if (Pressure < 1000)
            {
                return "Rainy";
            }
            else if (Pressure < 1020)
            {
                return "changing";
            }
            else if (Pressure < 1040) 
            {
                return "fair";
            }
            else 
            {
                return "very dry";
            }

                
           } 
        
    }
    #endregion

    #region Constructor
    public Barometer()
    {
        Pressure = 1000.0;
    }
#endregion


}
