using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOASATelematicsLib
{
    using System.ComponentModel.Design;

    using OASA.Telematics.API.Client;
    using OASA.Telematics.API.Models;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // var request = new GetStopNameAndCoordinatesCommand("400075");
            // var request = new GetRoutesDetailsAndStopsCommand("2045");
            var request = new GetMasterLinesCommand();
            var response = request.Execute().Result;

            Console.ReadKey();
        }
    }
}


