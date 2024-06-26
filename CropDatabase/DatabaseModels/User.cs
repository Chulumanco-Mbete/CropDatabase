﻿using SQLite;

namespace CropDatabase.DatabaseModels
{
    public class User
    {
        [PrimaryKey, AutoIncrement] public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
