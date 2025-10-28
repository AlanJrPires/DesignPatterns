namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public class CarInsuranceProposalFactory : InsuranceProposalFactory
    {
        public override InsuranceProposal CreateProposal() => new CarInsuranceProposal();
    }
}
