using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed2
{
    sealed class vehicles
    {
        public void startEngine()
        {
            Console.WriteLine("Car Engine is start ");
        }
        public void StopEngine()
        {
            Console.WriteLine("Car Engine is stop ");
        }
    }
    class call
    {
        public static void Main(string[] args)
        {

            vehicles v = new vehicles();
            v.startEngine();
            Console.ReadKey();
        }
    }
}
