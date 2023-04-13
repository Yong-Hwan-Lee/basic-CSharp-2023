﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs29_filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Directory == Folder
            //  절대경로 -C:\\Dev, @"C:\Dev" 리터럴은 여러줄 문자열도 가능
            string curDirectory = @"C:\Temp";   //. 현재 디렉토리(상대경로) .. 부모폴더/
            Console.WriteLine("현재 디렉토리 정보");

            var dirs = Directory.GetDirectories(curDirectory); // var type모를때 사용 string[]
            foreach (var dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);

                Console.Write(dirInfo.Name);
                Console.WriteLine(" [{0}] ",dirInfo.Attributes);
            }

            Console.WriteLine("현재 디렉토리 파일정보");

            var files = Directory.GetFiles(curDirectory);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.Write(fileInfo.Name);
                Console.WriteLine(" [{0}]", fileInfo.Attributes);
            }

            // 특정 경로에 하위폴더/하위파일 조회

            string path = @"C:\Temp\Csharp_Bank"; // 만들고자하는 폴더 구분자로 /도 가능
            string sfile = "Test.log";  // 생성할 파일

            if(Directory.Exists(path))
            {
                Console.WriteLine("경로가 존재하여 파일을 생성합니다/");
                File.Create(path+@"\"+sfile);  // C:\Temp\Csharp_Bank\Test.log
            }
            else
            {
                Console.WriteLine($"해당경로가 없습니다 {path}, 만듭니다.");
                Directory.CreateDirectory(path);

                Console.WriteLine("경로를 생성하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile);
            }

        }
    }
}
