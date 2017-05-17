// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IObserver.cs" company="Mainul">
//   2017
// </copyright>
// <summary>
//   The Observer interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Observer
{
    /// <summary>
    /// The Observer interface.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="weatherDto">
        /// The weather Data.
        /// </param>
        void Update(WeatherDto weatherDto);
    }
}