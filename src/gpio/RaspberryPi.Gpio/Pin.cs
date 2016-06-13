// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pin.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Represents instance of general-purpose input/output pin
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using RaspberryPi.Gpio.Services;
using System;

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Represents instance of general-purpose input/output pin
    /// </summary>
    internal sealed class Pin : IPin
    {
        private readonly int _pinNumer;
        private readonly IGpioService _gpioService;

        internal Pin(int pinNumer, PinMode pinMode, IGpioService gpioService)
        {
            if (gpioService == null)
                throw new ArgumentNullException(nameof(gpioService));

            _pinNumer = pinNumer;
            _gpioService = gpioService;
            Mode = pinMode;
        }

        /// <summary>
        /// Writes specified value to the pin
        /// </summary>
        /// <param name="value">Value to be written to the pin</param>
        public void Write(PinValue value)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Reads value of pin
        /// </summary>
        /// <returns>Value that was read</returns>
        public PinValue Read()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets or sets pin mode
        /// </summary>
        public PinMode Mode { get; set; }
    }
}