// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BowAndArrowBehavior.cs" company="Mainul">
//   2017
// </copyright>
// //  <summary>
//   BowAndArrowBehavior.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Strategy
{
    /// <summary>
    ///     The bow and arrow behavior.
    /// </summary>
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        /// <summary>
        ///     The use weapon.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string UseWeapon()
        {
            return "use bow and arrow";
        }
    }
}