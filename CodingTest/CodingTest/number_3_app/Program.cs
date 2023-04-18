using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace number_3_app
{
    //상속할 부모클래스 나머지속성정의
    class Car
    {
        public string Name;
        public string Maker;
        public string Color;
        public int YearModel;
        public int MaxSpeed;
        public string UniqueNumber;

        public Car(string Name, string Maker, string Color, int YearModel, int MaxSpeed, string UniqueNumber)
        {
            this.Name = Name;
            this.Maker = Maker;
            this.Color = Color;
            this.YearModel = YearModel;
            this.MaxSpeed = MaxSpeed;
            this.UniqueNumber = UniqueNumber;
        }

        public void Start()
        {
            Console.WriteLine("{0}의 시동을 겁니다.", Name);
        }

        public void Accelerate() 
        {
            Console.WriteLine("최대시속 {0}km/h로 가속합니다", MaxSpeed);
        }
        public void TurnRight()
        { Console.WriteLine("{0}를 우회전합니다", Name); }
        public void Brake() { Console.WriteLine("{0}의 브레이크를 밟습니다.", Name); }
        

    }
    //상속받은 ElectricCar클래스 Recharge()메서드
    class ElectricCar : Car 
    {
        public ElectricCar(string Name, string Maker, string Color, int YearModel, int MaxSpeed, string UniqueNumber) : base(Name, Maker, Color, YearModel, MaxSpeed, UniqueNumber)
        { }
        public void Recharge()
        {
            Console.WriteLine("달리면서 배터리를 충전합니다.");
        }
    }

    //상속받을 HybridCar클래스
    class HybridCar : ElectricCar
    {
        public HybridCar(string Name, string Maker, string Color, int YearModel, int MaxSpeed, string UniqueNumber) : base(Name, Maker, Color, YearModel, MaxSpeed, UniqueNumber)
        {         }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HybridCar ioniq = new HybridCar("아이오닉","현대자동차","White",2018,220,"54라 3346");
            //ioniq.Name = "아이오닉";
            //ioniq.Maker = "현대자동차";
            //ioniq.Color = "White";
            //ioniq.YearModel = 2018;
            //ioniq.MaxSpeed = 220;
            //ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Brake();             
              
        }
    }
}
