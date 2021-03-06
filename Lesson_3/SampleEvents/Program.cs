﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEvents
{
    class Program
    {
        static private void TestHandler()
        {
            Console.WriteLine("TestHandler is called when the event fires.");
        }
        static void Main(string[] args)
        {
            ISampleEvents se = new SampleClass();
            se.SampleEvent +=
            new SampleDelegate(TestHandler);
            se.Invoke();
            Console.ReadKey();
        }
    }

}
