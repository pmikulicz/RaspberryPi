// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GpioController.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents implemenattion of general-purpose input/output controller for the system
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using RaspberryPi.Gpio.Services;
using System;

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Represents implemenattion of general-purpose input/output controller for the system
    /// </summary>
    public sealed class GpioController : IGpioController
    {
        private readonly IGpioService _gpioService;

        internal GpioController(IGpioService gpioService)
        {
            if (gpioService == null)
                throw new ArgumentNullException(nameof(gpioService));

            _gpioService = gpioService;
        }

        /// <summary>
        /// Opens specified pin and returns it's instance
        /// </summary>
        /// <param name="pinNumber">Pin number which is going to be opened.
        /// Default pin mode is set up for input</param>
        /// <returns>Instance of <see cref="IPin"/> with specified number</returns>
        public IPin OpenPin(int pinNumber)
        {
            return new Pin(pinNumber, PinMode.Input, _gpioService);
        }
    }
}