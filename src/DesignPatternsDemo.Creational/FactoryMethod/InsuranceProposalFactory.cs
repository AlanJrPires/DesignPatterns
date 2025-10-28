namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public abstract class InsuranceProposalFactory
    {
        public abstract InsuranceProposal CreateProposal();

        public void ProcessProposal()
        {
            var proposal = CreateProposal();
            proposal.Validate();
            proposal.CalculatePremium();
            proposal.Submit();
        }
    }  
}
