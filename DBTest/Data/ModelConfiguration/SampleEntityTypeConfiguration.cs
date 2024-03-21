using DBTest.Data.Inicialization;
using DBTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTest.Data.ModelConfiguration
{
    internal class SampleEntityTypeConfiguration : IEntityTypeConfiguration<Sample>
    {
        public void Configure(EntityTypeBuilder<Sample> builder)
        {
            builder.HasData(Seed.SampleSeed());
        }
    }
}