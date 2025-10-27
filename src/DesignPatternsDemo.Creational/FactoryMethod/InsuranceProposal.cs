using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public abstract class InsuranceProposal
    {
        public abstract void Validate();
        public abstract void CalculatePremium();
        public abstract void Submit();
    }
}
