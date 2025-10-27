using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public class HomeInsuranceProposalFactory : InsuranceProposalFactory
    {
        public override InsuranceProposal CreateProposal() => new HomeInsuranceProposal();
    }
}
