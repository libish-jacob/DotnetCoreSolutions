using Newtonsoft.Json;
using System;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // below line is to show that jason.net dlls are also published to the output folder. This is to make sure that third part dlls are also handled via this publish. There is a nuget reference to json.net
            var res = JsonConvert.SerializeObject(new object());

            Console.ReadLine();
        }
    }
}
