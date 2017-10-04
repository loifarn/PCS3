using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AnimalShelterManager.Classes
{
    class DatabaseHelper
    {
        private string info = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=AnimalShelterDB.accdb; Persist Security Info=False;";

        public DatabaseHelper()
        {

        }

        public void LoadShelterInfo(AnimalShelter animalShelter)
        {
            string queryString = "SELECT * FROM ShelterInfo;";

            using (OleDbConnection connection = new OleDbConnection(info))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    animalShelter.Name = reader.GetString(0);
                    animalShelter.TelephoneNumber = reader.GetString(1);
                }
                reader.Close();
                connection.Close();
            }

        }

        public void SaveDogWalk(Dog dog, string employeeName)
        {
            string queryString = $"INSERT INTO VALUES({100}{dog.ChipNumber.ToString()}{dog.LastWalk.ToShortDateString()}{employeeName})";

            using (OleDbConnection connection = new OleDbConnection(info))
            {
                OleDbCommand command = new OleDbCommand(info);
                command.CommandType = CommandType.Text;
                command.CommandText = queryString;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int GetNrWalks(Dog dog)
        {
            string queryString = $"SELECT Count(*) FROM DogsToWalk WHERE ChipNr = {dog.ChipNumber};";
            int numberOfWalks = 0;

            using (OleDbConnection connection = new OleDbConnection(info))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    numberOfWalks = reader.GetInt32(0);
                }

                reader.Close();
                connection.Close();
            }
            return numberOfWalks;
        }

        public List<string> GetEmployeesWalks(Dog dog)
        {
            
            throw new NotImplementedException();
        }
    }
}
