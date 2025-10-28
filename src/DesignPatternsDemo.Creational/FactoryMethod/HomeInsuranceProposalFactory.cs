namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public class HomeInsuranceProposalFactory : InsuranceProposalFactory
    {
        public override InsuranceProposal CreateProposal() => new HomeInsuranceProposal();
    }
}
