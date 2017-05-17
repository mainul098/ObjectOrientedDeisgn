// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeatherChannel.cs" company="Mainul">
//   2017
// </copyright>
// <summary>
//   The weather data.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Observer
{
    using System.Collections.Generic;

    /// <summary>
    ///     The weather data.
    /// </summary>
    public class WeatherChannel : ISubject
    {
        /// <summary>
        ///     The observers.
        /// </summary>
        private readonly IList<IObserver> observers = null;

        /// <summary>
        ///     The weather data.
        /// </summary>
        private WeatherDto weatherData;

        /// <summary>
        ///     Initializes a new instance of the <see cref="WeatherChannel" /> class.
        /// </summary>
        public WeatherChannel()
        {
            this.observers = new List<IObserver>();
        }

        /// <summary>
        /// The register observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        /// The remove observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        public void RemoveObserver(IObserver observer)
        {
            var index = this.observers.IndexOf(observer);
            if (index > 0)
            {
                this.observers.Remove(observer);
            }
        }

        /// <summary>
        ///     The notify observer.
        /// </summary>
        public void NotifyObserver()
        {
            foreach (var observer in this.observers)
            {
                observer.Update(this.weatherData);
            }
        }

        /// <summary>
        /// The set measurement.
        /// </summary>
        /// <param name="weatherDto">
        /// The weather data.
        /// </param>
        public void SetMeasurement(WeatherDto weatherDto)
        {
            this.weatherData = weatherDto;
            this.NotifyObserver();
        }
    }
}