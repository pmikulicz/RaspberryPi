using RaspberryPi.Gpio.Services;
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

        public IGpioControllerOptionsConfigurator SetGpioService(IGpioService gpioService)
        {
            if (gpioService == null)
                throw new ArgumentNullException(nameof(gpioService));

            _gpioControllerOptions.GpioService = gpioService;

            return this;
        }

        public IGpioControllerOptionsConfigurator SetPlatformType(PlatformType platformType)
        {
            _gpioControllerOptions.PlatformType = platformType;

            return this;
        }
    }
}