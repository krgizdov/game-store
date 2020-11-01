using Game_Store.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game_Store.Domain.Services
{
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetPaginatedActivitiesAsync(int page, int size);
    }
}
