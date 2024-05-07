using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CropDatabase.DatabaseModels.Tomatoe
{
    public class TomatoeDt
    {
        [PrimaryKey, AutoIncrement] public int TomatoeId { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }
        [ForeignKey(typeof(TomatoeDiseases))] public int TomatoeDiseasesId { get; set; }
    }
}
