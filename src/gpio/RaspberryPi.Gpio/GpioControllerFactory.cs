using RaspberryPi.Gpio.Services;
using System;

namespace RaspberryPi.Gpio
{
    public sealed class GpioControllerFactory : IGpioControllerFactory
    {
        public IGpioController Create(Action<IGpioControllerOptionsConfigurator> configurator)
        {
            if (configurator == null)
                throw new ArgumentNullException(nameof(configurator));

            var gpioControllerOptions = new GpioControllerOptions();
            configurator(new GpioControllerOptionsConfigurator(gpioControllerOptions));

            // TODO: check if IGpioService is correrct for current for platform type
            if (gpioControllerOptions.GpioService != null)
                return new GpioController(gpioControllerOptions.GpioService);

            return gpioControllerOptions.PlatformType == PlatformType.Windows
                ? new GpioController(new WindowsGpioService())
                : new GpioController(new LinuxGpioService());
        }
    }
}