namespace DesignPatternsDemo.Behavioral.Strategy
{
    public class HomePremiumCalculationStrategy : IPremiumCalculationStrategy
    {
        public decimal CalculatePremium()
        {
            Console.WriteLine("Calculando prêmio para seguro residencial");
            return 1500; // valor exemplo
        }
    }
}
