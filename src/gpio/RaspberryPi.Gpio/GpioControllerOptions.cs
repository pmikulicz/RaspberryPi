using RaspberryPi.Gpio.Services;
using System;

namespace RaspberryPi.Gpio
{
    internal sealed class GpioControllerOptions
    {
        public IGpioService GpioService { get; set; }

        public PlatformType PlatformType { get; set; }
    }
}