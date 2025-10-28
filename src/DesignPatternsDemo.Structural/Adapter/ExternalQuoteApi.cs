namespace DesignPatternsDemo.Structural.Adapter
{
    // Serviço externo hipotético, com método incompatível
    public class ExternalQuoteApi
    {
        public decimal FetchQuote(string type, string identifier)
        {
            if (type == "car")
                return 500; // cotação fixa para exemplo
            else if (type == "home")
                return 1200;
            return 0;
        }
    }
}
