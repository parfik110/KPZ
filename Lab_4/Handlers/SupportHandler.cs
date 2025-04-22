namespace Handlers
{
    public abstract class SupportHandler
    {
        protected SupportHandler? next;

        public void SetNext(SupportHandler next)
        {
            this.next = next;
        }

        public abstract bool Handle(string issue);
    }
}
