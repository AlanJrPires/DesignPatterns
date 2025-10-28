namespace DesignPatternsDemo.Behavioral.Strategy
{
    public class PremiumCalculator
    {
        private IPremiumCalculationStrategy _strategy;

        public PremiumCalculator(IPremiumCalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IPremiumCalculationStrategy strategy) => _strategy = strategy;

        public decimal ExecuteCalculation() => _strategy.CalculatePremium();
    }
}
