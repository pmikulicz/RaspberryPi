namespace RaspberryPi.Gpio.Services
{
    public interface IGpioService
    {
        bool IsAvailable();

        PlatformType Platform { get; }
    }
}