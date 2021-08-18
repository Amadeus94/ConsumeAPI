using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IActivityRepository
    {
        void StoreEntity(ActivityEntity activity);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<ActivityEntity>> GetActivitiesAsync();
        Task<ActivityEntity> GetActivityAsync(int id);
    }
}