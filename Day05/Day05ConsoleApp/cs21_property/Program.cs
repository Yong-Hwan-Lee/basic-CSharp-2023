﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace cs21_property
{   
    //privite
    class Boiler
    {
        private int temp; // 맴버 변수
        public int Temp//프로버티(속성)
        {
            get{ return temp; }
            set{
                if (temp <= 10 || temp >= 70)
                {
                    temp = 10;
                }
                else
                    temp = value;
            }
            
        }

        //위의 get;set;과 비교 // 아래의 Get메서드와 Set메서드는 Java에서만 사용, C# 은 거의 안씀.
        public void SetTemp(int temp)
        {
            if (temp <= 10 || temp >= 70)
            {
                //ConsoleWriteLine("수온설정값이 너무 낮거나 높습니다. 10~70도 사이로 지정해주세요");
                //return
                temp = 10;
            }
            else
            {
                this.temp = temp;
            }
        }
         public int GetTemp() { return this.temp;}
    }

    class Car
    {
        //string name;
        //string color;
        int year;
        string fuelType;
        //int door;
        string tireType;
        //string company;
        int price;
        string carIdNumber;
        string carPlateNumber;
        

        public string Name { get; set; } // 필터링이 필요없으면 맴버변수 필요없이 프로퍼티로 대체

        public string Color { get ; set ; }
            
        //들어오는 데이터를 필터링할때는 private 멤버변수와 public 프로퍼티를 둘다 사용
        public int Year {
            get { return year; }    // get=> year;
            set {
                if (value <= 1990 || value >= 2023)
                {
                    value = 2023;
                }
                year = value;
            }
        }
        public string FuelType { get=> fuelType;
            set 
            {
                if(value != "휘발유" || value !="경유")
                {
                    value = "휘발유";
                }
                fuelType = value;
            }
        }

        private int door;
        public int Door
        {
            get { return door; }
            set
            {
                if (value != 2 || value != 4)
                {
                    value = 4;
                }

                door = value;
            }
        }
        public string TireType { get => tireType; set => tireType = value; }
        public string Company { get; set; } = "현대자동차";
        public int Price { get => price; set => price = value; }
        public string CarIdNumber { get => carIdNumber; set => carIdNumber = value; }
        public string CarPlateNumber { get => carPlateNumber; set => carPlateNumber = value; }
    }

    interface IProduct
    {
        string ProductName { get; set; }

        void Produce();
    }

    class MyProduct : IProduct
    {
        private string productName;
        public string ProductName {
            get { return productName; }
            set { productName= value; }
                }

        public void Produce()
        {
            Console.WriteLine("{0}을(를) 생산합니다.", ProductName);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Boiler kitturami =new Boiler();
            //kitturami.temp = 60;

            //kitturami.temp = 300000;
            //kitturami.temp = -120;
            kitturami.SetTemp(50);
            Console.WriteLine(kitturami.GetTemp()); // 옛날방식

            Boiler navien = new Boiler();
            navien.Temp = 5000;
            Console.WriteLine(navien.Temp);

            Car ionic = new Car();
            ionic.Name = "아이오닉";    //get이 없으면 접근불가 ,set이 없으면 값 입력불가
            Console.WriteLine(ionic.Name);

            // 생성할 때 프로퍼티로 초기화
            Car genesis = new Car()
            {
                Name = "제네시스",
                FuelType = "휘발유",
                Color = "흰색",
                Door = 4,
                TireType = "광폭타이어",
                Year = 0,
            };

            Console.WriteLine("자동차 제조회사는 {0}", genesis.Company);
            Console.WriteLine("자동차 제조년도는 {0}", genesis.Year);
        }
    }
}
