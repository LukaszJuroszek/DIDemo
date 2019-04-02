using System;

namespace DIDemo.Services
{
    public static class FakeUtils
    {
        public static double In(Func<string, double> predicate) => predicate("In");
        public static double Out(Func<string, double> predicate, bool value) => predicate("out");
        public static void Wait(int value) { }
        private static double Furnace(string value = "Piec") { return double.MinValue; }
    }

    public interface IThermometer
    {
        double Read();
    }

    public class Thermometer : IThermometer
    {
        public double Read() => new Random().NextDouble();
    }

    public interface IHeater
    {
        void Disengage();
        void Engage();
    }

    public class Heater : IHeater
    {
        public void Engage() { }
        public void Disengage() { }
    }
}
