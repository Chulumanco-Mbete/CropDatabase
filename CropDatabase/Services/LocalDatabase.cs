using CropDatabase.DatabaseModels;
using CropDatabase.DatabaseModels.Carrots;
using CropDatabase.DatabaseModels.Onion;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace CropDatabase.Services
{
    public class LocalDatabase
    {
        private SQLiteConnection _dbConnection;

        public string GetDatabasePath()
        {
            string filename = "cropdata.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb, filename);
        }

        public LocalDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());

            //Database Tables
            _dbConnection.CreateTable<User>();
            _dbConnection.CreateTable<CarrotDt>();
        }

        public void SeedDatabase() 
        {
            if (_dbConnection.Table<User>().Count() == 0)
            {
                User user = new User()
                {
                    Name = "",
                    Surname = "",
                    Email = "",
                    PhoneNumber = "",
                    Password = "",
                    ConfirmPassword = ""
                };
                _dbConnection.Insert(user);
            }
            
            if (_dbConnection.Table<CarrotDt>().Count() == 0)
            {
                CarrotDt carrot = new CarrotDt()
                {
                    Name = "",
                    SoilType = "",
                    WaterIntake = "",
                    SoilPrep = "",
                    TimeToPlant = ""
                };
                _dbConnection.Insert(carrot);
            }
            
            if (_dbConnection.Table<OnionDt>().Count() == 0)
            {
                OnionDt onion = new OnionDt()
                {
                    Name = "",
                    SoilType = "",
                    WaterIntake = "",
                    SoilPrep = "",
                    TimeToPlant = ""
                };
                _dbConnection.Insert(onion);
            }
        }

        public void UpdateUser(User user)
        {
            _dbConnection.Update(user);
        }

        public User GetUserById(int id)
        {
            User user = _dbConnection.Table<User>().Where(x => x.UserId == id).FirstOrDefault();

            if (user != null)
                _dbConnection.GetChildren(user, true);

            return user;
        }
    }
}
