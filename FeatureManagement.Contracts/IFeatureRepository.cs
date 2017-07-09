namespace FeatureManagement.Contracts
{
    public interface IFeatureRepository<T> : IRepository<T> where T : IAggregateRoot
    {
    }
}
