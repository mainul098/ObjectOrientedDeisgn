// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KnifeBehavior.cs" company="Mainul">
//   2017
// </copyright>
// //  <summary>
//   KnifeBehavior.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Strategy
{
    /// <summary>
    ///     The knife behavior.
    /// </summary>
    public class KnifeBehavior : IWeaponBehavior
    {
        /// <summary>
        ///     The use weapon.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string UseWeapon()
        {
            return "use knife";
        }
    }
}