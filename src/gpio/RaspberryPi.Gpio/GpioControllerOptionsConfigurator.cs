using System;

namespace RaspberryPi.Gpio
{
    internal sealed class GpioControllerOptionsConfigurator : IGpioControllerOptionsConfigurator
    {
        private readonly GpioControllerOptions _gpioControllerOptions;

        public GpioControllerOptionsConfigurator(GpioControllerOptions gpioControllerOptions)
        {
            if (gpioControllerOptions == null)
                throw new ArgumentNullException(nameof(gpioControllerOptions));

            _gpioControllerOptions = gpioControllerOptions;
        }
    }
}