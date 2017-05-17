// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleClient.cs" company="">
//   
// </copyright>
// //  <summary>
//   VehicleClient.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactory
{
    /// <summary>
    ///     The 'Client' class
    /// </summary>
    class VehicleClient
    {
        /// <summary>
        /// The bike.
        /// </summary>
        IBike bike;

        /// <summary>
        /// The scooter.
        /// </summary>
        IScooter scooter;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleClient"/> class.
        /// </summary>
        /// <param name="factory">
        /// The factory.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        public VehicleClient(IVehicleFactory factory, string type)
        {
            this.bike = factory.GetBike(type);
            this.scooter = factory.GetScooter(type);
        }

        /// <summary>
        /// The get bike name.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetBikeName()
        {
            return this.bike.Name();
        }

        /// <summary>
        /// The get scooter name.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetScooterName()
        {
            return this.scooter.Name();
        }
    }
}