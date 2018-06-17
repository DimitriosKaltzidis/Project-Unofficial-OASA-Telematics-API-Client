namespace OASA.Telematics.DemoTest
{
    using System;

    using OASA.Telematics.Client.Client;

    class Program
    {
        static void Main(string[] args)
        {
            var request = new GetMasterLinesCommand();
            var response = request.Execute().Result;

            foreach (var masterLine in response)
            {
                Console.WriteLine($"{masterLine.MasterLineCode} - {masterLine.LineCode}");
            }

            Console.ReadKey();
        }
    }
}


