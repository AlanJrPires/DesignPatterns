namespace DesignPatternsDemo.Creational.Singleton
{
    public sealed class InsuranceConfig
    {
        private static readonly Lazy<InsuranceConfig> instance = new(() => new InsuranceConfig());

        public static InsuranceConfig Instance => instance.Value;

        public string CompanyName { get; private set; }

        private InsuranceConfig()
        {
            CompanyName = "Seguro Exemplo S.A.";
        }
    }
}
