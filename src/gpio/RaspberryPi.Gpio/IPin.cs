// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPin.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//  Represents interface of general-purpose input/output pin
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Represents interface of general-purpose input/output pin
    /// </summary>
    public interface IPin
    {
        /// <summary>
        /// Writes specified value to the pin
        /// </summary>
        /// <param name="value">Value to be written to the pin</param>
        void Write(PinValue value);

        /// <summary>
        /// Reads value of pin
        /// </summary>
        /// <returns>Value that was read</returns>
        PinValue Read();

        /// <summary>
        /// Gets or sets pin mode
        /// </summary>
        PinMode Mode { get; set; }
    }
}