using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cs03_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object형식
            // int == system.Int32
            // long == system.Int64
            Int32 idata = 1024;
            Console.WriteLine(idata);
            Console.WriteLine(idata.GetType());

            long ldata = 1024;
            Console.WriteLine(ldata);
            Console.WriteLine(ldata.GetType());

            object lobj = (object)ldata;    // 박싱 : 데이터타입값을 object로 담아라
            Console.WriteLine(lobj);
            Console.WriteLine(lobj.GetType());

            long udata = (long)lobj;        // 언박싱 : object를 원래 데이터타입으로 바꿔라
            Console.WriteLine(udata);
            Console.WriteLine(udata.GetType());

            double ddata = 3.141592;
            object pobj = (object)ddata;        
            double pdata = (double)pobj;

            Console.WriteLine(pobj);
            Console.WriteLine(pobj.GetType());
            
            Console.WriteLine(pdata);
            Console.WriteLine(pdata.GetType());

            short sdata = 32000;
            int indata = sdata;
            Console.WriteLine(indata);

            long lndata = long.MaxValue;
            Console.WriteLine(lndata);
            indata = (int)lndata;
            Console.WriteLine(indata);

            // float double간 형변환
            float fval = 3.141592f; // float형은 마지막에 f써야함
            Console.WriteLine("fval = " + fval);
            double dval = (double)fval;
            Console.WriteLine("dval = " + dval);
            Console.WriteLine(fval == dval);
            Console.WriteLine(dval == 3.141592);

            // 정말 중요! 실무에서
            int numival = 1024;
            string strival= numival.ToString();
            Console.WriteLine(strival);
            Console.WriteLine(numival);
            //Console.WriteLine(numival ==strival);
            Console.WriteLine(strival.GetType());
            Console.WriteLine(numival.GetType());

            double numdval = 3.14159265358979;
            string strdval = numdval.ToString();
            Console.WriteLine(strdval);

            //문자열을 숫자로 
            //문자열내에 숫자가 아닌 특수문자나 정수인데 .이 있거나 하면 예외발생
            string originstr = "34567890";      
            int convval = Convert.ToInt32(originstr);       //int.Parse() 동일
            Console.WriteLine(convval);
            originstr = "1.2345";
            float convfloat = float.Parse(originstr);
            Console.WriteLine(convfloat);
            // 예외발생하지 않도록 형변환 방법
            originstr = "123.0f";
            float ffval; 
            // TryParse는 예외가 발생하면 값은 0 대체, 예외가 없으면 원래값으로
            float.TryParse(originstr, out ffval);          // 예외발생하지않게 숫자변환
            Console.Write(ffval);

            const double pi = 3.14159265358979;
            Console.WriteLine(pi);

            //pi = 4.56; //상수는 값변경불가


        }
    }
}
