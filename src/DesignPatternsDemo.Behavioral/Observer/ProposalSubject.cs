namespace DesignPatternsDemo.Behavioral.Observer
{
    public class ProposalSubject
    {
        private readonly List<IProposalObserver> _observers = new();

        public void Attach(IProposalObserver observer) => _observers.Add(observer);
        public void Detach(IProposalObserver observer) => _observers.Remove(observer);

        public void Notify(string message)
        {
            foreach (var observer in _observers)
                observer.Update(message);
        }
    }
}
