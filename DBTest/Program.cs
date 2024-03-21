using DBTest.Data;
using DBTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DBTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestContext context = new();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            List<SampleType> sampleTypes = context.SampleType
                .Include(x => x.Sample)
                .ToList();

            JsonSerializerOptions jsonOptions = new() { ReferenceHandler = ReferenceHandler.Preserve };

            foreach (SampleType sampleType in sampleTypes)
            {
                Console.WriteLine($"{sampleType.Name} ({sampleType.Id})");
                foreach (Sample sample in sampleType.Sample)
                {
                    Console.WriteLine($"\t{JsonSerializer.Serialize(sample, jsonOptions)}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Migráció befejeződött.");
        }
    }
}