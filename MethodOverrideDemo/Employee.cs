namespace MethodOverrideDemo
{
    public class Employee : PersonModel1
    {
        public decimal HourlyRate { get; set; }

        public virtual decimal GetpaycheckAmount(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }
}
