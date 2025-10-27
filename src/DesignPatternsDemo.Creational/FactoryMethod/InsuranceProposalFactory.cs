using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
