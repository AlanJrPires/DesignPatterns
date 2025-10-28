namespace DesignPatternsDemo.Creational.FactoryMethod
{
    public abstract class InsuranceProposal
    {
        public abstract void Validate();
        public abstract void CalculatePremium();
        public abstract void Submit();
    }
}
