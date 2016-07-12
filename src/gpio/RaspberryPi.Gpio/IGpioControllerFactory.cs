// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGpioControllerFactory.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents interface of a factory which is responsible for creating gpio controller
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Represents interface of a factory which is responsible for creating gpio controller
    /// </summary>
    public interface IGpioControllerFactory
    {
        /// <summary>
        /// Creates gpio controller and returns its instance
        /// </summary>
        /// <param name="configurator">Gpio controller configurator <see cref="IGpioControllerOptionsConfigurator"/></param>
        /// <returns>Instance of <see cref="IGpioController"/></returns>
        IGpioController Create(Action<IGpioControllerOptionsConfigurator> configurator);
    }
}