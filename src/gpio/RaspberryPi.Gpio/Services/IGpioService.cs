using System;

namespace RaspberryPi.Gpio.Services
{
    public interface IGpioService
    {
        bool IsAvailable();

        PlatformID Platform { get; }
    }
}