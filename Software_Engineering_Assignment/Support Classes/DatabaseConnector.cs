using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment.Support_Classes
{
    class DatabaseConnector
    {
        //This class is to be accessable to all other classes in this project
        private static DatabaseConnector instance;
        private static string connectionString;

        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;


        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        public static DatabaseConnector Instance
        {
            get
            {
                if (instance == null)
                {
                    //set connection string
                    connectionString = Properties.Settings.Default.ConnectionString;
                    //Initalize DatabaseConnector instance
                    instance = new DatabaseConnector();
                }
                return instance;
            }
        }

        public void OpenConnection()
        {
            sqlConnection = new SqlConnection(connectionString); //Initalize sql connection object
            sqlConnection.Open(); //Open sql connection
        }

        public void CloseConnection()
        {
            sqlConnection.Close(); //Close SQL connection
        }

        public Bay GetBay(int bayNumber)
        {
            //To be implemented
            return new Bay(bayNumber);
        }

        public Patient GetPatient(int bayNumber, int bedNumber)
        {
            //To be implemented
            OpenConnection(); //Open Connection

            CloseConnection(); //Close Connection
            return new Patient() { bayNumber = bayNumber, bedNumber = bedNumber};
        }

        public List<Staff> GetAllStaff()
        {
            OpenConnection(); //Open Connection

            CloseConnection(); //Close Connection
            return null;
        }

        public Staff GetStaff(int staffID)
        {
            OpenConnection(); //Open Connection

            using (DataSet dataSet = new DataSet())
            {
                sqlDataAdapter = new SqlDataAdapter(Constants.GetStaff(staffID), sqlConnection);
                sqlDataAdapter.Fill(dataSet);
                //Copy Data From dataset to Staff Object and return it
            }

            CloseConnection(); //Close Connection
            return null;
        }

        public bool VerifyLogin(int staffID, string password)
        {
            OpenConnection(); //Open Connection

            CloseConnection(); //Close Connection
            return false; 
        }
    }
}
