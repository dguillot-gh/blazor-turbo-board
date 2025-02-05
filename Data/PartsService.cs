using System;
using System.Linq;
using System.Threading.Tasks;

namespace TurboKanban.Data
{
    public class PartService
    {
        private static readonly string[] PartNames = new[]
        {
            "Bolt", "Nut", "Screw", "Washer", "Gear", "Bearing", "Shaft", "Pulley", "Belt", "Chain"
        };

        public Task<Part[]> GetPartsAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new Part
            {
                Id = index,
                Name = PartNames[rng.Next(PartNames.Length)],
                Quantity = rng.Next(1, 100),
                Price = rng.Next(1, 1000) / 10m,
                Description = "Description for " + PartNames[rng.Next(PartNames.Length)]
            }).ToArray());
        }
    }
}
