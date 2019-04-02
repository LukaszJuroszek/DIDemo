namespace DIDemo.Services
{
    public class FurnaceImprovedByInterfaceBase
    {
        public void Regulate(IThermometer thermometer, IHeater heater, double minTemp, double maxTemp)
        {
            while (true)
            {
                while (thermometer.Read() > minTemp)
                    FakeUtils.Wait(1);
                heater.Engage();

                while (thermometer.Read() < maxTemp)
                    FakeUtils.Wait(1);
                heater.Disengage();
            }
        }
    }
}
