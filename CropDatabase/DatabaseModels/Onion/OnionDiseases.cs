using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CropDatabase.DatabaseModels.Onion
{
    public class OnionDiseases
    {
        [PrimaryKey, AutoIncrement] public int OnionDiseasesId { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseCauses { get; set; }
        public string DiseaseControllMeasures { get; set; }
    }
}
