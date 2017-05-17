// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWeaponBehavior.cs" company="Mainul">
//   2017
// </copyright>
// //  <summary>
//   IWeaponBehavior.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Strategy
{
    /// <summary>
    ///     The WeaponBehavior interface.
    /// </summary>
    public interface IWeaponBehavior
    {
        /// <summary>
        ///     The use weapon.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        string UseWeapon();
    }
}