// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GpioControllerFactory.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents implementation of a factory which is responsible for creating gpio controller
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using RaspberryPi.Gpio.Services;
using System;

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Represents implementation of a factory which is responsible for creating gpio controller
    /// </summary>
    public sealed class GpioControllerFactory : IGpioControllerFactory
    {
        /// <summary>
        /// Creates gpio controller and returns its instance
        /// </summary>
        /// <param name="configurator">Gpio controller configurator <see cref="IGpioControllerOptionsConfigurator"/></param>
        /// <returns>Instance of <see cref="IGpioController"/></returns>
        public IGpioController Create(Action<IGpioControllerOptionsConfigurator> configurator)
        {
            if (configurator == null)
                throw new ArgumentNullException(nameof(configurator));

            var gpioControllerOptions = new GpioControllerOptions();
            configurator(new GpioControllerOptionsConfigurator(gpioControllerOptions));

            // TODO: check if IGpioService is correrct for current for platform type

            if (gpioControllerOptions.GpioService != null)
                return new GpioController(gpioControllerOptions.GpioService);

            return gpioControllerOptions.PlatformType == PlatformType.Windows
                ? new GpioController(new WindowsGpioService())
                : new GpioController(new LinuxGpioService());
        }
    }
}