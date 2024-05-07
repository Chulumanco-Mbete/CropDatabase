using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CropDatabase.DatabaseModels.Potatoe
{
    public class PotatoeDt
    {
        [PrimaryKey, AutoIncrement] public int PotatoeId { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }
        [ForeignKey(typeof(PotatoeDiseases))] public int PotatoeDiseasesId { get; set; }
    }
}
