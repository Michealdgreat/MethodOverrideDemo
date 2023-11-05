using System;

namespace MethodOverrideDemo
{
    public class Tesla : Car
    {

        public override void startCar()
        {
            Console.WriteLine("Think about your destination");
        }
        public virtual void SetClock()
        {
            Console.WriteLine("It set itself");
        }
    }

}
