using SQLite;

namespace CropDatabase.DatabaseModels.Potatoe
{
    public class PotatoeDiseases
    {
        [PrimaryKey, AutoIncrement] public int PotatoeDiseasesId { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseCauses { get; set; }
        public string DiseaseControllMeasures { get; set; }
    }
}
