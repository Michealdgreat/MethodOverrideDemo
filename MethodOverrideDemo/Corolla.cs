using System;

namespace MethodOverrideDemo
{
    public class Corolla : Car 
    {
        public virtual void SetClock()
        {
            Console.WriteLine("Fiddle with the corolla clock");
        }
    }

}
