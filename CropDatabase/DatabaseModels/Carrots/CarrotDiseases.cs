using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CropDatabase.DatabaseModels.Carrots
{
    public class CarrotDiseases
    {
        [PrimaryKey, AutoIncrement] public int CarrotDiseasesId { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseCauses { get; set; }
        public string DiseaseControllMeasures { get; set; }
    }
}
