using System.ComponentModel.DataAnnotations;

namespace DBTest.Models
{
    internal class SampleType
    {
        [Key]
        public SampleTypes Id { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        public virtual ICollection<Sample> Sample { get; set; } = new List<Sample>();
    }
}