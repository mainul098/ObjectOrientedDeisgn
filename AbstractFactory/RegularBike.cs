// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegularBike.cs" company="">
//   
// </copyright>
// //  <summary>
//   RegularBike.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactory
{
    /// <summary>
    ///     The 'ProductA1' class
    /// </summary>
    class RegularBike : IBike
    {
        /// <summary>
        /// The name.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string Name()
        {
            return "Regular Bike- Name";
        }
    }
}