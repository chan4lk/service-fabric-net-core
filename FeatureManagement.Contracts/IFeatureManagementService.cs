using Microsoft.ServiceFabric.Services.Remoting;
using System.Threading.Tasks;

namespace FeatureManagement.Contracts
{
    public interface IFeatureManagementService : IService
    {
        Task AddAsync(Entity feature);

        Task UpdateAsync(Entity feature);

        Task DeleteAsync(Entity feature);

        Task GetAsync(Entity feature);

    }
}
