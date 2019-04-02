namespace DIDemo.Services
{
    public class FurnaceImprovedBase
    {
        public void Regulate(Thermometer thermometer, Heater heater, double minTemp, double maxTemp)
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
