// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KnightTest.cs" company="Mainul">
//   2017
// </copyright>
// //  <summary>
//   KnightTest.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Strategy.Tests
{
    using NUnit.Framework;

    /// <summary>
    ///     The knight test.
    /// </summary>
    [TestFixture]
    public class KnightTest
    {
        /// <summary>
        ///     The test knight weapon behavior.
        /// </summary>
        [Test]
        public void ShouldFailedKnightWeaponBehavior()
        {
            // Arrange
            var knight = new Knight();

            // Act
            var val = knight.Fight();

            // Assert
            Assert.IsFalse(val == "use knife");
        }

        /// <summary>
        /// The should passed knight weapon behavior.
        /// </summary>
        [Test]
        public void ShouldPassedKnightWeaponBehavior()
        {
            // Arrange
            var knight = new Knight();

            // Act
            var val = knight.Fight();

            // Assert
            Assert.IsTrue(val == "use bow and arrow");
        }
    }
}