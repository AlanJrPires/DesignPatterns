namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public class HomeInsuranceProposal : InsuranceProposal
    {
        public override void Validate() => Console.WriteLine("Validando proposta de seguro residencial");
        public override void CalculatePremium() => Console.WriteLine("Calculando prêmio para seguro residencial");
        public override void Submit() => Console.WriteLine("Enviando proposta de seguro residencial");
    }
}
