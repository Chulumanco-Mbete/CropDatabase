using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CropDatabase.DatabaseModels.Spinach
{
    public class SpinachDiseases
    {
        [PrimaryKey, AutoIncrement] public int SpinachDiseasesId { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseCauses { get; set; }
        public string DiseaseControllMeasures { get; set; }
    }
}
