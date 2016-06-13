// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlatformType.cs" company="Patryk Mikulicz">
//   Copyright (c) 2016 Patryk Mikulicz.
// </copyright>
// <summary>
//   Identifies the platform type supported by an assembly
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RaspberryPi.Gpio
{
    /// <summary>
    /// Identifies the platform type supported by an assembly
    /// </summary>
    public enum PlatformType
    {
        /// <summary>
        /// Represents Windows operating system as a platform type
        /// </summary>
        Windows = 0,

        /// <summary>
        ///  Represents Linux operating system as a platform type
        /// </summary>
        Linux = 1
    }
}