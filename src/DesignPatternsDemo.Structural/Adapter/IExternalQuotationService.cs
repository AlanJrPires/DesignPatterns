namespace DesignPatternsDemo.Structural.Adapter
{
    public interface IExternalQuotationService
    {
        decimal GetCarInsuranceQuote(string carModel);
        decimal GetHomeInsuranceQuote(string homeAddress);
    }
}
