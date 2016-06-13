namespace RaspberryPi.Gpio.Services
{
    public sealed class LinuxGpioService : IGpioService
    {
        public bool IsAvailable()
        {
            throw new System.NotImplementedException();
        }

        public PlatformType Platform => PlatformType.Linux;
    }
}