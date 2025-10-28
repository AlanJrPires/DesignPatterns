using DesignPatternsDemo.Creational.Singleton;
using DesignPatternsDemo.Creational.FactoryMethod;
using DesignPatternsDemo.Structural.Adapter;
using DesignPatternsDemo.Structural.Decorator;
using DesignPatternsDemo.Behavioral.Observer;
using DesignPatternsDemo.Behavioral.Strategy;

namespace DesignPatternsDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Design Patterns Demo para Propostas de Seguro ===\n");

            // Singleton
            Console.WriteLine("-> Singleton (Configuração global):");
            var config1 = InsuranceConfig.Instance;
            var config2 = InsuranceConfig.Instance;
            Console.WriteLine($"Empresa: {config1.CompanyName}");
            Console.WriteLine($"Mesma instância? {ReferenceEquals(config1, config2)}\n");

            // Factory Method
            Console.WriteLine("-> Factory Method (Criação de propostas):");
            InsuranceProposalFactory carFactory = new CarInsuranceProposalFactory();
            carFactory.ProcessProposal();
            InsuranceProposalFactory homeFactory = new HomeInsuranceProposalFactory();
            homeFactory.ProcessProposal();
            Console.WriteLine();

            // Adapter
            Console.WriteLine("-> Adapter (Consulta cotação de API externa):");
            IExternalQuotationService quotationService = new QuotationAdapter();
            Console.WriteLine($"Cotação carro: {quotationService.GetCarInsuranceQuote("ModeloX")}");
            Console.WriteLine($"Cotação casa: {quotationService.GetHomeInsuranceQuote("EndereçoY")}\n");

            // Decorator
            Console.WriteLine("-> Decorator (Aplicar desconto especial):");
            InsuranceProposal carProposal = new CarInsuranceProposal();
            var discountedProposal = new SpecialDiscountDecorator(carProposal);
            discountedProposal.Validate();
            discountedProposal.CalculatePremium();
            discountedProposal.Submit();
            Console.WriteLine();

            // Observer
            Console.WriteLine("-> Observer (Notificação de agentes):");
            ProposalSubject subject = new ProposalSubject();
            var agent1 = new Agent("Agente João");
            var agent2 = new Agent("Agente Maria");
            subject.Attach(agent1);
            subject.Attach(agent2);
            subject.Notify("Nova proposta para seguro de carro criada.");
            Console.WriteLine();

            // Strategy
            Console.WriteLine("-> Strategy (Estratégias para cálculo de prêmio):");
            var premiumCalculator = new PremiumCalculator(new CarPremiumCalculationStrategy());
            Console.WriteLine($"Prêmio calculado: {premiumCalculator.ExecuteCalculation()}");
            premiumCalculator.SetStrategy(new HomePremiumCalculationStrategy());
            Console.WriteLine($"Prêmio calculado: {premiumCalculator.ExecuteCalculation()}");

            Console.WriteLine("\n=== Fim da Demo ===");
        }
    }
}