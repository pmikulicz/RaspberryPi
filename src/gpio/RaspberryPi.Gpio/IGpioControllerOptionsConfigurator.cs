// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGpioControllerOptionsConfigurator.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents interface of a component which configures options for gpio controller
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using RaspberryPi.Gpio.Services;

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Represents interface of a component which configures options for gpio controller
    /// </summary>
    public interface IGpioControllerOptionsConfigurator
    {
        /// <summary>
        /// Sets specified gpio service which will be used by gpio controller
        /// </summary>
        /// <param name="gpioService">Gpio service which will be used by gpio controller</param>
        /// <returns>Instance of <see cref="IGpioControllerOptionsConfigurator"/></returns>
        IGpioControllerOptionsConfigurator SetGpioService(IGpioService gpioService);

        /// <summary>
        /// Sets platform type under which the default gpio service will be selected
        /// </summary>
        /// <param name="platformType"></param>
        /// <returns></returns>
        IGpioControllerOptionsConfigurator SetPlatformType(PlatformType platformType);
    }
}