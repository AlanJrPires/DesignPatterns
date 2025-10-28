using DesignPatternsDemo.Creational.FactoryMethod;

namespace DesignPatternsDemo.Structural.Decorator
{
    public class SpecialDiscountDecorator : InsuranceProposalDecorator
    {
        public SpecialDiscountDecorator(InsuranceProposal proposal) : base(proposal) { }

        public override void CalculatePremium()
        {
            _proposal.CalculatePremium();
            Console.WriteLine("Aplicando desconto especial na proposta");
        }
    }
}
