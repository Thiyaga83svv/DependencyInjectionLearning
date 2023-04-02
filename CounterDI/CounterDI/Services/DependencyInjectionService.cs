namespace CounterDI.Services
{
    public class DependencyInjectionService : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public DependencyInjectionService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }
}
