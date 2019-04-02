using System;

namespace DIDemo.Services
{
    public class FurnaceBase
    {
        private readonly bool _engage = true;
        private readonly bool _disengage = false;
        private double Thermometer(string value = "Termometr") => new Random().NextDouble();
        private double Furnace(string value = "Piec") { return double.MinValue; }

        public void Regulate(double minTemp, double maxTemp)
        {
            while (true)
            {
                while (FakeUtils.In(Thermometer) > minTemp)
                    FakeUtils.Wait(1);
                FakeUtils.Out(Furnace, _engage);

                while (FakeUtils.In(Thermometer) < maxTemp)
                    FakeUtils.Wait(1);
                FakeUtils.Out(Furnace, _disengage);
            }
        }
    }
}
