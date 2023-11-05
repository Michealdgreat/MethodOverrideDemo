using System;

namespace MethodOverrideDemo
{
    public abstract class Car
    {
        public virtual void startCar()
        {
            Console.WriteLine("Turn Key and Start");
        }

        public virtual void SetClock() { }
    }

}
