// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinuxGpioService.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents implmenetation of gpio service dedidcated for Linux platform
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RaspberryPi.Gpio.Services
{
    /// <summary>
    /// Represents implmenetation of gpio service dedidcated for Linux platform
    /// </summary>
    public sealed class LinuxGpioService : IGpioService
    {
        /// <summary>
        /// Returns value indicating whether gpio service is available and ready to use
        /// </summary>
        /// <returns></returns>
        public bool IsAvailable()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns platform type which service is dedicated for
        /// </summary>
        public PlatformType Platform => PlatformType.Linux;
    }
}