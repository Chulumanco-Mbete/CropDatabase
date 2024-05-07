using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CropDatabase.DatabaseModels.Carrots
{
    public class CarrotDt
    {
        [PrimaryKey, AutoIncrement] public int CarrotId { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }
        [ForeignKey(typeof(CarrotDiseases))] public int CarrotDiseasesId { get; set; }
    }
}
