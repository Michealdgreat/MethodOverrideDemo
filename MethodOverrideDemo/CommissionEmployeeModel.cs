namespace MethodOverrideDemo
{
    public class CommissionEmployeeModel : Employee
    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetpaycheckAmount(int hoursWorked)
        {
            decimal initialPay = base.GetpaycheckAmount(hoursWorked);

            return initialPay + CommissionAmount;
        }

    }
}
