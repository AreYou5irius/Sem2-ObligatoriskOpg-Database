using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Hotelklasser;

namespace ControllerKlasser
{
    public class ManageHotel : IManage<Hotel>
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DatabaseOpgave;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region GetAll
        public List<Hotel> GetAll()
        {
            List<Hotel> hotelList = new List<Hotel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = $"SELECT * from Hotel";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Hotel newHotel = new Hotel();
                    newHotel.Hotel_No = reader.GetInt32(0);
                    newHotel.Name = reader.GetString(1);
                    newHotel.Address = reader.GetString(2);

                    hotelList.Add(newHotel);
                }
                command.Connection.Close();
            }

            return hotelList;
        }
        #endregion

        #region GetFromId
        public Hotel GetFromId(int objectNr)
        {
            Hotel hotel = new Hotel();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"SELECT * from Hotel WHERE Hotel_No = {objectNr}";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //int id = reader.GetInt32(0);
                    //string name = reader.GetString(1);
                    //string address = reader.GetString(2);

                    //hotel = new Hotel(id, name, address);

                    hotel.Hotel_No = reader.GetInt32(0);
                    hotel.Name = reader.GetString(1);
                    hotel.Address = reader.GetString(2);

                }
                command.Connection.Close();
            }

            return hotel;
        }
        #endregion

        #region Create
        public void Create(Hotel obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"INSERT into Hotel Values('{obj.Hotel_No}', '{obj.Name}', '{obj.Address}')";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }
        }
        #endregion

        #region Update
        public void Update(Hotel obj, int objectNr)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"UPDATE Hotel SET name='{obj.Name}', address='{obj.Address}' WHERE Hotel_No ={objectNr}";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
        #endregion

        #region Delete
        public void Delete(int objectNr)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"Delete from Hotel where Hotel_No = {objectNr}";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }

        } 
        #endregion

    }

}
