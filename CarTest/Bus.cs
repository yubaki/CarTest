using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    class Bus : Car
    {
        private string[] travelRoute;
        private int[] wage;
        private string busCompany;

        public Bus()
        {
            travelRoute = new string[] { "バス停A", "バス停B", "バス停C" };
            wage = new int[] { 120, 150, 180 };
            busCompany = "バス会社";
        }

        public void PushStopButton()
        {
            if (CheckEngineFlag() == true)
            {
                Console.Out.WriteLine("停車ボタンが押されました。");
            }
        }

        public void CurrencyExchange()
        {
            Console.Out.WriteLine("両替を行います。");
        }

        public void InBusAnnounce()
        {
            if (CheckEngineFlag() == true)
            {
                Console.Out.WriteLine("バスアナウンスを行います。");
            }
        }
    }
}
