// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GpioControllerOptionsConfigurator.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents implementation of component which configures options for gpio controller
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using RaspberryPi.Gpio.Services;
using System;

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Represents implementation of component which configures options for gpio controller
    /// </summary>
    internal sealed class GpioControllerOptionsConfigurator : IGpioControllerOptionsConfigurator
    {
        private readonly GpioControllerOptions _gpioControllerOptions;

        public GpioControllerOptionsConfigurator(GpioControllerOptions gpioControllerOptions)
        {
            if (gpioControllerOptions == null)
                throw new ArgumentNullException(nameof(gpioControllerOptions));

            _gpioControllerOptions = gpioControllerOptions;
        }

        /// <summary>
        /// Sets specified gpio service which will be used by gpio controller
        /// </summary>
        /// <param name="gpioService">Gpio service which will be used by gpio controller</param>
        /// <returns>Instance of <see cref="IGpioControllerOptionsConfigurator"/></returns>
        public IGpioControllerOptionsConfigurator SetGpioService(IGpioService gpioService)
        {
            if (gpioService == null)
                throw new ArgumentNullException(nameof(gpioService));

            _gpioControllerOptions.GpioService = gpioService;

            return this;
        }

        /// <summary>
        /// Sets platform type under which the default gpio service will be selected
        /// </summary>
        /// <param name="platformType"></param>
        /// <returns>Instance of <see cref="IGpioControllerOptionsConfigurator"/></returns>
        public IGpioControllerOptionsConfigurator SetPlatformType(PlatformType platformType)
        {
            _gpioControllerOptions.PlatformType = platformType;

            return this;
        }
    }
}