using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOASATelematicsLib
{
    using System.ComponentModel.Design;

    using OASA.Telematics.Client;
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


