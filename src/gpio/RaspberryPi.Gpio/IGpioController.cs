// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGpioController.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents interface of general-purpose input/output controller for the system
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using RaspberryPi.Gpio.Services;

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Represents interface of general-purpose input/output controller for the system
    /// </summary>
    public interface IGpioController
    {
        /// <summary>
        /// Opens specified pin and returns it's instance
        /// </summary>
        /// <param name="pinNumber">Pin number which is going to be opened</param>
        /// <returns>Instance of <see cref="IPin"/> with specified number</returns>
        IPin OpenPin(int pinNumber);

        /// <summary>
        /// Sets <see cref="IGpioService"/> for the controller
        /// </summary>
        /// <param name="gpioService"></param>
        void SetGpioService(IGpioService gpioService);
    }
}