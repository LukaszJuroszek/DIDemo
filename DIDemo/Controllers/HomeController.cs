using Microsoft.AspNetCore.Mvc;
using DIDemo.Services;

namespace DIDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly FurnaceImprovedByInterfaceAndDIBase _furnaceImprovedByInterfaceAndDIBase;

        public HomeController(FurnaceImprovedByInterfaceAndDIBase furnaceImprovedByInterfaceAndDIBase)
        {
            _furnaceImprovedByInterfaceAndDIBase = furnaceImprovedByInterfaceAndDIBase;
        }

        public void Basic()
        {
            var minTemp = 0.0;
            var maxTemp = 1.0;

            var fb = new FurnaceBase();

            fb.Regulate(minTemp, maxTemp);
        }

        public void Improved()
        {
            var minTemp = 0.0;
            var maxTemp = 1.0;

            var thermometer = new Thermometer();
            var heater = new Heater();
            var fbi = new FurnaceImprovedBase();

            fbi.Regulate(thermometer, heater, minTemp, maxTemp);
        }

        public void ImprovedByInterface()
        {
            var minTemp = 0.0;
            var maxTemp = 1.0;

            var thermometer = new Thermometer();
            var heater = new Heater();

            var fbibi = new FurnaceImprovedByInterfaceBase();

            fbibi.Regulate(thermometer, heater, minTemp, maxTemp);
        }

        public void ImprovedByInterfaceAndDI()
        {
            var minTemp = 0.0;
            var maxTemp = 1.0;

            _furnaceImprovedByInterfaceAndDIBase.Regulate(minTemp, maxTemp);
        }
    }
}
