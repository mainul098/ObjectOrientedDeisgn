// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HondaFactory.cs" company="">
//   
// </copyright>
// //  <summary>
//   HondaFactory.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactory
{
    using System;

    /// <summary>
    ///     The 'ConcreteFactory1' class.
    /// </summary>
    class HondaFactory : IVehicleFactory
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
        /// <exception cref="Exception">
        /// </exception>
        public IBike GetBike(string Bike)
        {
            switch (Bike)
            {
                case "Sports": return new SportsBike();
                case "Regular": return new RegularBike();
                default: throw new Exception(string.Format("Vehicle '{0}' cannot be created", Bike));
            }
        }

        /// <summary>
        /// The get scooter.
        /// </summary>
        /// <param name="Scooter">
        /// The scooter.
        /// </param>
        /// <returns>
        /// The <see cref="IScooter"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        public IScooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports": return new Scooty();
                case "Regular": return new RegularScooter();
                default: throw new Exception(string.Format("Vehicle '{0}' cannot be created", Scooter));
            }
        }
    }
}