using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class DataBaseService
    {
        public static MySqlConnection CreateConnectino()
        {
            try
            {
                string host = "localhost";
                int port = 3306;
                string database = "dbtur_firm";
                string username = "root";
                string password = "1234";

                string connString = "Server=" + host + ";Database=" + database +
                    ";port=" + port + ";User Id=" + username + ";password=" + password;

                return new MySqlConnection(connString);
            }
            catch (Exception)
            {

                throw new Exception("База данных не была подключена!");
            }
            
        }

        public static List<string> GetTours(MySqlConnection myCon)
        {
            try
            {
                myCon.Open();
                string sqlTours = "SELECT * FROM tours";

                MySqlCommand command = new MySqlCommand(sqlTours, myCon);
                MySqlDataReader reader = command.ExecuteReader();
                var myList = new List<string>();

                while (reader.Read())
                {
                    myList.Add($"Город |{reader[1]}| Цена |{reader[2]}|BYN");
                }
                reader.Close();
                myCon.Close();

                return myList;
            }
            catch (Exception)
            {
                throw new Exception("Туры отсутствуют");
            }
            
        }

        public static List<string> GetTourists(MySqlConnection myCon)
        {
            try
            {
                myCon.Open();
                string sqlTourists = "SELECT * FROM tourists";

                MySqlCommand command = new MySqlCommand(sqlTourists, myCon);
                MySqlDataReader reader = command.ExecuteReader();
                var myList = new List<string>();

                while (reader.Read())
                {
                    myList.Add($"Имя |{reader[1]}| Фамилия |{reader[2]}|");
                }
                reader.Close();
                myCon.Close();

                return myList;
            }
            catch (Exception)
            {
                throw new Exception("Туристы отсутствуют!");
            }
            
        }

        public static void DeleteTour(MySqlConnection myCon, List<string> selectedTour)
        {
            try
            {
                myCon.Open();
                string sqlTours = "DELETE FROM tours WHERE name = @selectedTour";

                MySqlCommand command = new MySqlCommand(sqlTours, myCon);

                command.Parameters.AddWithValue("@selectedTour", selectedTour[1]);
                command.ExecuteNonQuery();


                myCon.Close();
            }
            catch (Exception)
            {
                throw new Exception("Не выбран тур для удаления");
            }
            
        }

        public static void AddTour(MySqlConnection myCon, string tourName, string tourCost)
        {
            try
            {
                myCon.Open();

                string sql = "INSERT INTO tours" + "(name, cost) Values(@name, @cost)";

                MySqlCommand command = new MySqlCommand(sql, myCon);

                command.Parameters.AddWithValue("@name", tourName);
                command.Parameters.AddWithValue("@cost", Convert.ToDecimal(tourCost));
                command.ExecuteNonQuery();

                myCon.Close();
            }
            catch (Exception)
            {
                throw new Exception("Не введены данные");   
            }
            
        }

        public static void AddTourist(MySqlConnection myCon, string touristName, string touristSName)
        {
            try
            {
                myCon.Open();

                string sql = "INSERT INTO tourists" + "(name, secondName) Values(@name, @secondName)";

                MySqlCommand command = new MySqlCommand(sql, myCon);

                command.Parameters.AddWithValue("@name", touristName);
                command.Parameters.AddWithValue("@secondName", touristSName);
                command.ExecuteNonQuery();


                myCon.Close();
            }
            catch (Exception)
            {
                throw new Exception("Не введены данные");
            }
           
        }

        public static void ChangeTourist(MySqlConnection myCon, List<string> selectedTourist, string touristNameChange, string touristSNameChange)
        {
            try
            {
                myCon.Open();
                string sqlTours = "UPDATE tourists SET name = @name, secondName = @secondName WHERE name = @selectedTourist";

                MySqlCommand command = new MySqlCommand(sqlTours, myCon);

                command.Parameters.AddWithValue("@name", touristNameChange);
                command.Parameters.AddWithValue("@secondName", touristSNameChange);

                command.Parameters.AddWithValue("@selectedTourist", selectedTourist[1]);
                command.ExecuteNonQuery();


                myCon.Close();
            }
            catch (Exception)
            {
                throw new Exception("Не выбран турист");
            }
            
        }

    }
}
