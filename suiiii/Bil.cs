using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suiiii
{
    public class Bil
    {
        public void MotorStartet()
        {
            Console.WriteLine("Motoren er startet");
        }

        public void MotorSlukket()
        {
            Console.WriteLine("Motoren er Slukket");
        }

        public void fillgas(double liters)
        {
            Console.WriteLine("Filled tank with: " + liters + " liters");
        }
 
        public void FillGas(double liters, bool isDiesel)
        {

            if (isDiesel)
            {
                Console.WriteLine("Filled tank with: " + liters + " liters of" + " diesel");
            }
            else if (!isDiesel)
            {
                Console.WriteLine("Filled tank with: " + liters + " liters of" +  " petrol");
            }

        }


        public void RemainingGas(double i)
        {
            Console.WriteLine("GasLeft: " + i);
        }



    }
}
