// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVehicleFactory.cs" company="">
//   
// </copyright>
// //  <summary>
//   IVehicleFactory.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactory
{
    /// <summary>
    ///     The 'AbstractFactory' interface.
    /// </summary>
    interface IVehicleFactory
    {
        /// <summary>
        /// The get bike.
        /// </summary>
        /// <param name="Bike">
        /// The bike.
        /// </param>
        /// <returns>
        /// The <see cref="IBike"/>.
        /// </returns>
        IBike GetBike(string Bike);

        /// <summary>
        /// The get scooter.
        /// </summary>
        /// <param name="Scooter">
        /// The scooter.
        /// </param>
        /// <returns>
        /// The <see cref="IScooter"/>.
        /// </returns>
        IScooter GetScooter(string Scooter);
    }
}