using RaspberryPi.Gpio.Exceptions;
using RaspberryPi.Gpio.Services;
using System;

namespace RaspberryPi.Gpio
{
    public sealed class GpioController : IGpioController
    {
        private static IGpioService _gpioService;

        public IPin OpenPin(int pinNumber)
        {
            return new Pin(pinNumber, PinMode.Input, _gpioService);
        }

        public void SetGpioService(IGpioService gpioService)
        {
            if (gpioService == null)
                throw new ArgumentNullException(nameof(gpioService));

            if (Environment.OSVersion.Platform != gpioService.Platform)
                throw new OsVersionMismatchException(
                    $"Cannot set up gpio service dedicated for os platform '{gpioService.Platform}' because current os platform is '{Environment.OSVersion.Platform}'");

            _gpioService = gpioService;
        }
    }
}