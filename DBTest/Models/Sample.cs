using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DBTest.Models
{
    internal class Sample
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public SampleTypes SampleTypeId { get; set; }

        [JsonIgnore]
        public SampleType? SampleType { get; set; }

        [Required, StringLength(48)]
        public string? Barcode { get; set; }

        [Required, StringLength(100)]
        public string? PatientName { get; set; }
    }
}