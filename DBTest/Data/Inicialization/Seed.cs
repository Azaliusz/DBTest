using DBTest.Models;

namespace DBTest.Data.Inicialization
{
    internal static class Seed
    {
        public static IEnumerable<Sample> SampleSeed()
        {
            int id = 1;

            return
            [
                new Sample() { Id = id++, SampleTypeId = SampleTypes.Urine, Barcode = "T001", PatientName = "Kis Pista" },
                new Sample() { Id = id++, SampleTypeId = SampleTypes.Urine, Barcode = "T002", PatientName = "Tóth János" },
                new Sample() { Id = id++, SampleTypeId = SampleTypes.BOF, Barcode = "T003", PatientName = "Teller Ede" },
                new Sample() { Id = id++, SampleTypeId = SampleTypes.Urine, Barcode = "T004", PatientName = "Tóth Rita" },
                new Sample() { Id = id++, SampleTypeId = SampleTypes.BOF, Barcode = "T005", PatientName = "Volly Zoli" },
                new Sample() { Id = id++, SampleTypeId = SampleTypes.QC, Barcode = "T006", PatientName = "-" },
                new Sample() { Id = id++, SampleTypeId = SampleTypes.Urine, Barcode = "T007", PatientName = "Győri Dorottya" },
            ];
        }

        public static IEnumerable<SampleType> SampleTypeSeed()
        {
            return
            [
                new SampleType() { Id = SampleTypes.Urine, Name = "Vizelet" },
                new SampleType() { Id = SampleTypes.QC, Name = "Ellenörző folyadék" },
                new SampleType() { Id = SampleTypes.BOF, Name = "Test folyadék" },
            ];
        }
    }
}