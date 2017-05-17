// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Character.cs" company="Mainul">
//   2017
// </copyright>
// //  <summary>
//   Character.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Strategy
{
    /// <summary>
    ///     The character.
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        ///     Gets or sets the weapon behavior.
        /// </summary>
        public IWeaponBehavior WeaponBehavior { get; set; }

        /// <summary>
        ///     The fight.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public abstract string Fight();
    }
}