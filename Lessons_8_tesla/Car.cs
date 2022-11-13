using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_8_tesla
{


    internal abstract class Car : Tesla
    {
        public int _сonsumption { get; private set; }
        public int _battery { get; private set; }
        public Car(int сonsumption)
        {
            _сonsumption = сonsumption;
        }

        public void Drive(int dist)
        {
            int сharge = dist * _сonsumption;

            if (сharge > _battery)
            {
                Console.WriteLine(" Not enough energy ");
                return;
            }
            else
                Console.WriteLine("Start Drive");
            _battery = _battery - сharge;
        }

        public void Refuel(int сharger)
        {
            _battery = _battery + сharger;
        }




    }
}