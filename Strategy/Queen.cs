// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queen.cs" company="Mainul">
//   2017
// </copyright>
// //  <summary>
//   Queen.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Strategy
{
    /// <summary>
    ///     The knight.
    /// </summary>
    public class Queen : Character
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Queen" /> class.
        /// </summary>
        public Queen()
        {
            this.WeaponBehavior = new KnifeBehavior();
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