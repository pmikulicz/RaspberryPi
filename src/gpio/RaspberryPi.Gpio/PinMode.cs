// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PinMode.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Defines possible pin modes
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Defines possible pin modes
    /// </summary>
    public enum PinMode
    {
        /// <summary>
        /// Represents input mode of a pin
        /// </summary>
        Input = 0,

        /// <summary>
        ///  Represents output mode of a pin
        /// </summary>
        Output = 1
    }
}