using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public class CarInsuranceProposal : InsuranceProposal
    {
        public override void Validate() => Console.WriteLine("Validando proposta de seguro de carro");
        public override void CalculatePremium() => Console.WriteLine("Calculando prêmio para seguro de carro");
        public override void Submit() => Console.WriteLine("Enviando proposta de seguro de carro");
    }
}
