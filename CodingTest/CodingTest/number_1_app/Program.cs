using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_1_app
{
    class Boiler
    {
        private string brand;
        private byte voltage;
        private int temperature;


        public string Brand 
        {
            get { return brand; } 
            set { brand = value; }
        }        


        public byte Voltage
        {
            get { return this.voltage; }
            set
            {
                //110v과 220v만 저장할 수 있도록 처리
                if (value == 110 || value == 220)
                {
                    voltage = value;
                }
                else
                {
                    Console.WriteLine("전압은 110v와 220v만 가능");
                }
            }
        }
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                // 물 온도는 5도 이하면 5도로 70도 이상이면 70도로 제한
                if (value < 5)
                {
                    temperature = 5;
                }
                else if (value > 70)
                {
                    temperature = 70;
                }
                else
                {
                    temperature = value;
                }
  
            }
        }
        public void PrintAll()
        {
            Console.WriteLine("{0} 사의 전압은 {1}V, 온도는{2}도입니다", brand, Voltage, Temperature);
        }

    }
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();
        }
    }
}
