using System.Collections.Generic;
using System.Threading.Tasks;

namespace TurboKanban.Data
{
    public class PartsService
    {
        private readonly List<Parts> _parts = new();

        public Task<List<Parts>> GetPartsAsync()
        {
            return Task.FromResult(_parts);
        }

        public Task AddPartAsync(Parts part)
        {
            _parts.Add(part);
            return Task.CompletedTask;
        }

        public Task RemovePartAsync(Parts part)
        {
            _parts.Remove(part);
            return Task.CompletedTask;
        }
    }
}
