using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CropDatabase.DatabaseModels.Tomatoe
{
    public class TomatoeDiseases
    {
        [PrimaryKey, AutoIncrement] public int TomatoeDiseasesId { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseCauses { get; set; }
        public string DiseaseControllMeasures { get; set; }
    }
}
