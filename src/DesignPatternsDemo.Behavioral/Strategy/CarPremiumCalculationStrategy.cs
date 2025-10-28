namespace DesignPatternsDemo.Behavioral.Strategy
{
    public class CarPremiumCalculationStrategy : IPremiumCalculationStrategy
    {
        public decimal CalculatePremium()
        {
            Console.WriteLine("Calculando prêmio para seguro de carro");
            return 1000; // valor exemplo
        }
    }
}
