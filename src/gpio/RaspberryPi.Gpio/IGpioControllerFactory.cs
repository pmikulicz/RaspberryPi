using System;

namespace RaspberryPi.Gpio
{
    public interface IGpioControllerFactory
    {
        IGpioController Create(Action<IGpioControllerOptionsConfigurator> configurator);
    }
}