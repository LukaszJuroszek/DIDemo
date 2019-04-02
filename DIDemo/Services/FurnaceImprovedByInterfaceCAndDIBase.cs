namespace DIDemo.Services
{
    public class FurnaceImprovedByInterfaceAndDIBase
    {
        public readonly IThermometer _thermometer;
        public readonly IHeater _heater;

        public FurnaceImprovedByInterfaceAndDIBase(IThermometer thermometer, IHeater heater)
        {
            _thermometer = thermometer;
            _heater = heater;
        }

        public void Regulate(double minTemp, double maxTemp)
        {
            while (true)
            {
                while (_thermometer.Read() > minTemp)
                    FakeUtils.Wait(1);
                _heater.Engage();

                while (_thermometer.Read() < maxTemp)
                    FakeUtils.Wait(1);
                _heater.Disengage();
            }
        }
    }
}
