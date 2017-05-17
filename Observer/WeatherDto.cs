// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeatherDto.cs" company="Mainul">
//   2017
// </copyright>
// <summary>
//   Defines the WeatherData type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Observer
{
    /// <summary>
    ///     The weather data.
    /// </summary>
    public class WeatherDto
    {
        /// <summary>
        /// Gets or sets the temp.
        /// </summary>
        public double Temp { get; set; }

        /// <summary>
        /// Gets or sets the pressure.
        /// </summary>
        public double Pressure { get; set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Temperature : {0} and Pressure : {1}", this.Temp, this.Pressure);
        }
    }
}