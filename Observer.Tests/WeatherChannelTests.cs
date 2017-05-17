// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeatherChannelTests.cs" company="Mainul">
//   2017
// </copyright>
// <summary>
//   The weather channel tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Observer.Tests
{
    using System;

    using NUnit.Framework;

    /// <summary>
    /// The weather channel tests.
    /// </summary>
    [TestFixture]
    public class WeatherChannelTests
    {
        /// <summary>
        /// The should update statistics display.
        /// </summary>
        [Test]
        public void ShouldUpdateStatisticsDisplay()
        {
            // Arrange 
            var weatherChannel = new WeatherChannel();
            var statisticsDisplay = new StatisticsDisplay();
            var thirdPartyDisplay = new ThirdPartyDisplay();

            // Act
            weatherChannel.RegisterObserver(statisticsDisplay);
            weatherChannel.SetMeasurement(new WeatherDto() { Pressure = 120.0, Temp = 34.6 });

            // Assert
            Assert.IsNotNull(statisticsDisplay.WeatherData);
            Assert.IsTrue(statisticsDisplay.WeatherData.Pressure == 120.0);
            Assert.IsTrue(statisticsDisplay.WeatherData.Temp == 34.6);
            Assert.IsNull(thirdPartyDisplay.WeatherData);
        }

        /// <summary>
        /// The should update statistics display.
        /// </summary>
        [Test]
        public void ShouldUpdateAllDisplay()
        {
            // Arrange 
            var weatherChannel = new WeatherChannel();
            var statisticsDisplay = new StatisticsDisplay();
            var thirdPartyDisplay = new ThirdPartyDisplay();

            // Act
            weatherChannel.RegisterObserver(statisticsDisplay);
            weatherChannel.RegisterObserver(thirdPartyDisplay);
            weatherChannel.SetMeasurement(new WeatherDto() { Pressure = 120.0, Temp = 34.6 });

            // Assert
            Assert.IsNotNull(statisticsDisplay.WeatherData);
            Assert.IsTrue(statisticsDisplay.WeatherData.Pressure == 120.0);
            Assert.IsTrue(statisticsDisplay.WeatherData.Temp == 34.6);

            Assert.IsNotNull(thirdPartyDisplay.WeatherData);
            Assert.IsTrue(statisticsDisplay.WeatherData.Pressure == 120.0);
            Assert.IsTrue(statisticsDisplay.WeatherData.Temp == 34.6);
        }
    }
}