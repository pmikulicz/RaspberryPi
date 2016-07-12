// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GpioControllerOptions.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents model of gpio controller options
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using RaspberryPi.Gpio.Services;

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Represents model of gpio controller options
    /// </summary>
    internal sealed class GpioControllerOptions
    {
        /// <summary>
        /// Sets or gets gpio service
        /// </summary>
        public IGpioService GpioService { get; set; }

        /// <summary>
        /// Sets or gets platform type
        /// </summary>
        public PlatformType PlatformType { get; set; }
    }
}