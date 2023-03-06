namespace PayRollSystem
{
    public class PayRollCalculator : IPayRollCalculator
    {
        public decimal CalculatePayRoll(Employee employee)
        {
            if (employee.PayItems?.Any() == false)
                return 0;

            decimal result = employee.PayItems.Sum(x => x.Value);

            return result;
        }
    }
}
