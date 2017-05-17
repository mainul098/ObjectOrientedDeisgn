// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SportsBike.cs" company="">
//   
// </copyright>
// //  <summary>
//   SportsBike.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactory
{
    /// <summary>
    ///     The 'ProductA2' class
    /// </summary>
    class SportsBike : IBike
    {
        /// <summary>
        /// The name.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string Name()
        {
            return "Sports Bike- Name";
        }
    }
}