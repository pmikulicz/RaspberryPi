using RaspberryPi.Gpio.Services;
using System;

namespace RaspberryPi.Gpio
{
    public sealed class GpioController : IGpioController
    {
        private readonly IGpioService _gpioService;

        internal GpioController(IGpioService gpioService)
        {
            if (gpioService == null)
                throw new ArgumentNullException(nameof(gpioService));

            _gpioService = gpioService;
        }

        public IPin OpenPin(int pinNumber)
        {
            return new Pin(pinNumber, PinMode.Input, _gpioService);
        }
    }
}