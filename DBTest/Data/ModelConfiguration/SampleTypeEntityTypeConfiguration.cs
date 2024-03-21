using DBTest.Data.Inicialization;
using DBTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTest.Data.ModelConfiguration
{
    internal class SampleTypeEntityTypeConfiguration : IEntityTypeConfiguration<SampleType>
    {
        public void Configure(EntityTypeBuilder<SampleType> builder)
        {
            //builder
            //   .HasMany(e => e.Sample)
            //   .WithOne(e => e.SampleType)
            //   .HasForeignKey(e => e.SampleTypeId)
            //   .IsRequired()
            //   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(Seed.SampleTypeSeed());
        }
    }
}