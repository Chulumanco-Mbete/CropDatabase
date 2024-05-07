using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CropDatabase.DatabaseModels.Onion
{
    public class OnionDt
    {
        [PrimaryKey, AutoIncrement] public int OnionId { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }
        [ForeignKey(typeof(OnionDiseases))] public int OnionDiseasesId { get; set; }
    }
}
