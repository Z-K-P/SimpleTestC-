﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace day01.TestDay02Config
{
    class TestStream
    {
        public void ReaderFile()
        {
        //读取文件
        StreamReader reader = new StreamReader(@"C:\Users\Administrator\Desktop\a");
            string str = reader.ReadLine();
            string str2 = reader.ReadLine();
            Console.WriteLine(str);
            reader.Close();
        }

           
    }
}
