// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGpioService.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents interface of gpio service, which provides all gpio functionalities
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RaspberryPi.Gpio.Services
{
    /// <summary>
    /// Represents interface of gpio service, which provides all gpio functionalities
    /// </summary>
    public interface IGpioService
    {
        /// <summary>
        /// Returns value indicating whether gpio service is available and ready to use
        /// </summary>
        /// <returns></returns>
        bool IsAvailable();

        /// <summary>
        /// Returns platform type which service is dedicated for
        /// </summary>
        PlatformType Platform { get; }
    }
}