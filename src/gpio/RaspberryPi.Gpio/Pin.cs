using RaspberryPi.Gpio.Services;
using System;

namespace RaspberryPi.Gpio
{
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

        public void Write(PinValue value)
        {
            throw new System.NotImplementedException();
        }

        public PinValue Read()
        {
            throw new System.NotImplementedException();
        }

        public PinMode Mode { get; set; }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}