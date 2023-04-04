using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs09_nullcondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo myfoo = null;       // new Foo();
            // myfoo.member = 30;

            //int? bar;
            //if (myfoo != null)
            //{
            //    bar = myfoo.member;
            //}
            //else
            //{
            //    bar = null;
            //}

            // 위의 아홉줄(주석부분)을 모두 축약 / null이 아니면 값을집어넣어라
            int? bar = myfoo?.member;           
        }
    }

    class Foo
    {
        public int member;
    }
}
