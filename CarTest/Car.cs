using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    class Car
    {
        protected string maker;
        protected string type;
        protected string color;

        protected bool engineFlag;

        public Car()
        {
            maker = "メーカー";
            type = "車種";
            color = "色";
            engineFlag = false;
        }

        public void StartEngine()
        {
            if (CheckEngineFlag() == false)
            {
                Console.Out.WriteLine("車のエンジンを入れます。");
                engineFlag = true;
            }
            else
            {
                Console.Out.WriteLine("既に車のエンジンは始動しています。");
            }
        }

        public void StopEngine()
        {
            if (CheckEngineFlag() == true)
            {
                Console.Out.WriteLine("車のエンジンを停止します。");
                engineFlag = false;
            }
        }

        public void RunCar()
        {
            if (engineFlag == true)
            {
                Console.Out.WriteLine("車が発車します。");
            }

            else
            {
                Console.Out.WriteLine("車のエンジンが停止しています。");
            }
        }

        public void StopCar()
        {
            if (engineFlag == true)
            {
                Console.Out.WriteLine("車を停止します。");
            }

            else
            {
                Console.Out.WriteLine("車のエンジンが停止しています。");
            }
        }

        public bool CheckEngineFlag()
        {
            if (engineFlag == false)
            {
                Console.Out.WriteLine("エンジンは停止しています。");
            }
            return engineFlag;
        }
    }
}
