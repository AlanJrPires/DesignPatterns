using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public class CarInsuranceProposalFactory : InsuranceProposalFactory
    {
        public override InsuranceProposal CreateProposal() => new CarInsuranceProposal();
    }
}
