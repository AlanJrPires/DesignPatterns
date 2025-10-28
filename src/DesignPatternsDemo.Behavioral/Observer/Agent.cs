namespace DesignPatternsDemo.Behavioral.Observer
{
    public class Agent : IProposalObserver
    {
        private readonly string _name;

        public Agent(string name) { _name = name; }

        public void Update(string message) => Console.WriteLine($"{_name} recebeu notificação: {message}");
    }
}
