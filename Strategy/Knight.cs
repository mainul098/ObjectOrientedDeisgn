// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Knight.cs" company="Mainul">
//   2017
// </copyright>
// //  <summary>
//   Knight.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Strategy
{
    /// <summary>
    ///     The knight.
    /// </summary>
    public class Knight : Character
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Knight" /> class.
        /// </summary>
        public Knight()
        {
            this.WeaponBehavior = new BowAndArrowBehavior();
        }

        /// <summary>
        ///     The fight.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string Fight()
        {
            return this.WeaponBehavior.UseWeapon();
        }
    }
}