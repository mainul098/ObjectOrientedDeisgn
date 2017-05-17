// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Scooty.cs" company="">
//   
// </copyright>
// //  <summary>
//   Scooty.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AbstractFactory
{
    /// <summary>
    ///     The 'ProductB2' class
    /// </summary>
    class Scooty : IScooter
    {
        /// <summary>
        /// The name.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string Name()
        {
            return "Scooty- Name";
        }
    }
}