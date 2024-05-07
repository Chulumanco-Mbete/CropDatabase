using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CropDatabase.DatabaseModels.Spinach
{
    public class SpinachDt
    {
        [PrimaryKey, AutoIncrement] public int SpinachId { get; set; }
        public string Name { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string SoilPrep { get; set; }
        public string TimeToPlant { get; set; }
        [ForeignKey(typeof(SpinachDiseases))] public int SpinachDiseasesId { get; set; }
    }
}
