using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            Bus bus = new Bus();
            Track track = new Track();

            Console.Out.WriteLine("車クラスの処理を呼び出します。");
            car.StartEngine();
            car.RunCar();
            car.StopCar();
            car.StopEngine();

            Console.Out.WriteLine("\n\nバスクラスの処理を呼び出します。");
            bus.StartEngine();
            bus.RunCar();
            bus.StopCar();
            bus.PushStopButton();
            bus.CurrencyExchange();
            bus.InBusAnnounce();
            bus.StopEngine();

            Console.Out.WriteLine("\n\nトラッククラスの処理を呼び出します。");
            track.StartEngine();
            track.RunCar();
            track.StopCar();
            track.LoadLuggage(100);
            track.LowerLuggage(100);
            track.LoadLuggage(101);
            track.LowerLuggage(1);
            track.StopEngine();
        }
    }
}
