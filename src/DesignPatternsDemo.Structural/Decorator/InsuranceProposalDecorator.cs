using DesignPatternsDemo.Creational.FactoryMethod;

namespace DesignPatternsDemo.Structural.Decorator
{
    public abstract class InsuranceProposalDecorator : InsuranceProposal
    {
        protected readonly InsuranceProposal _proposal;

        protected InsuranceProposalDecorator(InsuranceProposal proposal)
        {
            _proposal = proposal;
        }

        public override void Validate() => _proposal.Validate();
        public override void CalculatePremium() => _proposal.CalculatePremium();
        public override void Submit() => _proposal.Submit();
    }
}
