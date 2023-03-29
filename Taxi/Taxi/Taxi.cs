using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTaxi
{
    public class Taxi
    {
        public string Name { get; set; }
        public bool Duty { get; set; }
        public int Passanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver : {0}", Name );
            Console.WriteLine( "Duty: {0}", Duty);
            Console.WriteLine("Number of Passanger: {0}", Passanger);
        }
        public void PickUpPassanger()
        {
            Console.WriteLine("\nUsep sedang Menjemput Penumpang");
        }
        public void DropOffPassanger()
        {
            Console.WriteLine("\nUsep Selesai Mengantar Penumpang");
        }
    }
}
