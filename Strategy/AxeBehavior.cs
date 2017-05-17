// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AxeBehavior.cs" company="Mainul">
//   2017
// </copyright>
// //  <summary>
//   AxeBehavior.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Strategy
{
    /// <summary>
    ///     The axe behavior.
    /// </summary>
    public class AxeBehavior : IWeaponBehavior
    {
        /// <summary>
        ///     The use weapon.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string UseWeapon()
        {
            return "use axe";
        }
    }
}