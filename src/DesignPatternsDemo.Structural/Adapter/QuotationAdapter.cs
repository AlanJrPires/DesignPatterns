namespace DesignPatternsDemo.Structural.Adapter
{
    // Adapter para adaptar ExternalQuoteApi para IExternalQuotationService
    public class QuotationAdapter : IExternalQuotationService
    {
        private readonly ExternalQuoteApi externalApi = new();

        public decimal GetCarInsuranceQuote(string carModel)
            => externalApi.FetchQuote("car", carModel);

        public decimal GetHomeInsuranceQuote(string homeAddress)
            => externalApi.FetchQuote("home", homeAddress);
    }
}
