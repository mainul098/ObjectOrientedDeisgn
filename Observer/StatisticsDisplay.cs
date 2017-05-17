// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StatisticsDisplay.cs" company="Mainul">
//   2017
// </copyright>
// <summary>
//   The statistics display.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Observer
{
    /// <summary>
    ///     The statistics display.
    /// </summary>
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        /// <summary>
        /// Gets or sets the weather data.
        /// </summary>
        public WeatherDto WeatherData { get; set; }

        /// <summary>
        /// The display.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string Display()
        {
            return string.Format("Statistics Display : {0}", this.WeatherData.ToString());
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="weatherDto">
        /// The weather data.
        /// </param>
        public void Update(WeatherDto weatherDto)
        {
            this.WeatherData = weatherDto;
        }
    }
}