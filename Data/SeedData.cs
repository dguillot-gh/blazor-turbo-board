namespace TurboKanban.Data;

public static class SeedData
{
    public static void Initialize(PartsContext db)
    {
        var parts = new Parts[]
        {
            new Parts()
            {
                Name = "SR20 T25 Turbo",
                Description = "A turbo from a sr20",
                Price = 130.0m,

            },
        };
        db.Parts.AddRange(parts);
        db.SaveChanges();
    }
}


