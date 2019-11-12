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
            sqlDataAdapter = null;
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
            Staff staff;

            using (DataSet dataSet = new DataSet())
            {
                sqlDataAdapter = new SqlDataAdapter(Constants.GetStaff(staffID), sqlConnection);
                sqlDataAdapter.Fill(dataSet); //Copy Data From dataset to Staff Object and return it

                List<string> rawStaffData = new List<string>();

                DataTable staffTable = dataSet.Tables[0];
                DataRow row = staffTable.Rows[0];

                foreach (DataColumn column in staffTable.Columns)
                {
                    rawStaffData.Add(row[column].ToString());
                }

                staff = new Staff(rawStaffData);
            }

            CloseConnection(); //Close Connection

            return staff;
        }


        /// <summary>
        /// Method returning dataset of the whole 'Alarm' table
        /// </summary>
        /// <returns></returns>
        public DataSet GetAlarms()
        {
            //Open connection to database
            OpenConnection();

            //Create dataset to hold the 'Alarm' table
            DataSet alarms = new DataSet();

            //Pass a SELECT command to the adapter
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Alarm",sqlConnection);

            //Fill the 'alarms' dataset with 'Alarm' table
            sqlDataAdapter.Fill(alarms);

            //Close connection to database
            CloseConnection();

            //Return filled dataset
            return alarms;
        }

        public bool VerifyLogin(int staffID, string password)
        {
            OpenConnection(); //Open Connection

            using (DataSet dataSet = new DataSet())
            {
                sqlDataAdapter = new SqlDataAdapter(Constants.GetStaffPassword(staffID), sqlConnection);
                sqlDataAdapter.Fill(dataSet); //Copy Data From dataset to Staff Object and return it

                DataTable staffTable = dataSet.Tables[0];
                DataRow row = staffTable.Rows[0];
                DataColumn column = staffTable.Columns[0];

                CloseConnection(); //Close Connection

                return password == row[column].ToString();
            }
        }
    }
}
