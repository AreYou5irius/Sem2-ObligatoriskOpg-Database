using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Hotelklasser;

namespace ControllerKlasser
{
    public class ManageFacility : IManage<Facility>
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DatabaseOpgave;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region GetAll
        public List<Facility> GetAll()
        {

            List<Facility> facilityList = new List<Facility>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = $"SELECT * from Facility";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Facility newFacility = new Facility();

                    newFacility.Facility_Id = reader.GetInt32(0);
                    newFacility.Facility_Name = reader.GetString(1);
                    newFacility.Type = reader.GetString(2);

                    facilityList.Add(newFacility);
                }
                command.Connection.Close();
            }

            return facilityList;
        }
        #endregion

        #region GetFromId
        public Facility GetFromId(int objectNr)
        {
            Facility facility = new Facility();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"SELECT * from Facility WHERE Facility_Id = {objectNr}";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                  
                    facility.Facility_Id = reader.GetInt32(0);
                    facility.Facility_Name = reader.GetString(1);
                    facility.Type = reader.GetString(2);

                }
                command.Connection.Close();
            }

            return facility;
        }
        #endregion
        
        #region Create
        public void Create(Facility obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"INSERT into Facility Values('{obj.Facility_Id}', '{obj.Facility_Name}', '{obj.Type}')";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }
        }
        #endregion

        #region Update
        public void Update(Facility obj, int objectNr)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = $"UPDATE Facility SET facility_name='{obj.Facility_Name}', type='{obj.Type}' WHERE Facility_Id ={objectNr}";  
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
                string queryString = $"Delete from Facility where Facility_Id = {objectNr}";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }

        } 
        #endregion
    }
}
