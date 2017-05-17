// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegularScooter.cs" company="">
//   
// </copyright>
// //  <summary>
//   RegularScooter.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactory
{
    /// <summary>
    ///     The 'ProductB1' class
    /// </summary>
    class RegularScooter : IScooter
    {
        /// <summary>
        /// The name.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}