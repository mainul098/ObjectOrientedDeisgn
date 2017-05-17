// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThirdPartyDisplay.cs" company="Mainul">
//   2017
// </copyright>
// <summary>
//   The third party display.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Observer
{
    /// <summary>
    /// The third party display.
    /// </summary>
    public class ThirdPartyDisplay : IObserver, IDisplayElement
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
            return string.Format("Third Party Display : {0}", this.WeatherData.ToString());
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="weatherDto">
        /// The weather Data.
        /// </param>
        public void Update(WeatherDto weatherDto)
        {
            this.WeatherData = weatherDto;
        }
    }
}