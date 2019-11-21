using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Software_Engineering_Assignment.Support_Classes
{
    internal class DatabaseConnector
    {
        //This class is to be accessable to all other classes in this project
        private static DatabaseConnector instance;
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;


        public static string ConnectionString { get; private set; }

        public static DatabaseConnector Instance
        {
            get
            {
                if (instance == null)
                {
                    //set connection string
                    ConnectionString = Properties.Settings.Default.ConnectionString;
                    //Initalize DatabaseConnector instance
                    instance = new DatabaseConnector();
                }
                return instance;
            }
        }

        public void OpenConnection()
        {
            sqlConnection = new SqlConnection(ConnectionString); //Initalize sql connection object
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

        public List<Patient> GetAllPatientesFromBay(int bayNumber)
        {
            List<Patient> patients = new List<Patient>();
            OpenConnection(); //Open Connection

            using (DataSet dataSet = new DataSet())
            {
                //Get data from class Constants
                sqlDataAdapter = new SqlDataAdapter(Constants.GetPatientsFromBay(bayNumber), sqlConnection);
                sqlDataAdapter.Fill(dataSet);

                DataTable patientTable = dataSet.Tables[0];

                foreach (DataRow row in patientTable.Rows)
                {
                    List<string> rawPatientData = new List<string>();
                    foreach (DataColumn column in patientTable.Columns)
                    {
                        rawPatientData.Add(row[column].ToString());
                    }
                    patients.Add(new Patient(rawPatientData));
                }
            }
            CloseConnection(); //Close Connection
            return patients;
        }


        public Patient GetPatient(int bayNumber, int bedNumber)
        {
            try
            {
                List<Patient> patientsFromBay = GetAllPatientesFromBay(bayNumber);
                return patientsFromBay.Where(x => x.bedNumber == bedNumber).ToArray()[0];

            }
            catch (Exception)
            {
                return new Patient() { FirstName = "Empty", Surname = "Record", bedNumber = bedNumber };

            }
        }

        public List<Staff> GetAllStaff()
        {
            OpenConnection(); //Open Connection
            List<Staff> staffList = new List<Staff>();

            using (DataSet dataSet = new DataSet())
            {
                //Get data from class Constants
                sqlDataAdapter = new SqlDataAdapter(Constants.GetStaffId, sqlConnection);
                sqlDataAdapter.Fill(dataSet);

                DataTable staffIdTable = dataSet.Tables[0];
                DataColumn column = staffIdTable.Columns[0];

                foreach (DataRow row in staffIdTable.Rows)
                {
                    int staffID = int.Parse(row[column].ToString());
                    staffList.Add(GetStaff(staffID));
                }
            }

            CloseConnection(); //Close Connection

            return staffList;

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

        public List<Staff> GetOnCallStaff(string date)
        {
            try
            {
                OpenConnection(); //Open Connection
                List<Staff> staffList = new List<Staff>();

                using (DataSet dataSet = new DataSet())
                {
                    sqlDataAdapter = new SqlDataAdapter(Constants.GetStaffOnCall(date), sqlConnection);
                    sqlDataAdapter.Fill(dataSet); //Copy Data From dataset to Staff Object and return it

                    List<string> rawStaffData = new List<string>();

                    DataTable staffTable = dataSet.Tables[0];
                    DataColumn column = staffTable.Columns[0];

                    foreach (DataRow row in staffTable.Rows)
                    {
                        int staffID = int.Parse(row[column].ToString());
                        staffList.Add(GetStaff(staffID));
                    }
                }

                CloseConnection(); //Close Connection

                return staffList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Staff> GetUnregisteredStaff(string date)
        {
            try
            {
                OpenConnection(); //Open Connection
                List<Staff> staffList = new List<Staff>();

                using (DataSet dataSet = new DataSet())
                {
                    sqlDataAdapter = new SqlDataAdapter(Constants.GetStaffUnregistered(date), sqlConnection);
                    sqlDataAdapter.Fill(dataSet); //Copy Data From dataset to Staff Object and return it

                    List<string> rawStaffData = new List<string>();

                    DataTable staffTable = dataSet.Tables[0];
                    DataColumn column = staffTable.Columns[0];

                    foreach (DataRow row in staffTable.Rows)
                    {
                        int staffID = int.Parse(row[column].ToString());
                        staffList.Add(GetStaff(staffID));
                    }
                }

                CloseConnection(); //Close Connection

                return staffList;
            }
            catch (Exception)
            {
                return null;
            }
        }



        public void RegisterStaff(int staffId, string date)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(Constants.RegisterStaff(staffId), sqlConnection);
            sqlCommand.Parameters.AddWithValue("@date", $"{date}");
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void UnregisterStaff(int staffId, string date)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(Constants.UnregisterStaff(staffId), sqlConnection);
            sqlCommand.Parameters.AddWithValue("@date", $"{date}");
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }



        /// <summary>
        /// Method returning DataTable for 'Alarm' table in db
        /// </summary>
        /// <returns></returns>
        public DataTable GetAlarms()
        {
            //Open connection to database
            OpenConnection();

            //Create dataset to hold data
            DataSet alarms = new DataSet();

            //Pass a SELECT command to the adapter
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Alarm", sqlConnection);

            //Fill the 'alarms' dataset with data
            sqlDataAdapter.Fill(alarms);

            //Close connection to database
            CloseConnection();

            //Pick just the table from the whole dataset
            DataTable alarmsTable = alarms.Tables[0];
            //Return table
            return alarmsTable;
        }

        /// <summary>
        /// Method returning a dataset specified by the fields in management page
        /// </summary>
        /// <returns></returns>
        public DataTable GetMatchingEvents(string table, string conditions)
        {
            DataSet results = new DataSet();
            OpenConnection();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + table + conditions , sqlConnection);

            sqlDataAdapter.Fill(results);

            CloseConnection();

            DataTable resultsTable = results.Tables[0];         
            return resultsTable;
        }

        public bool VerifyLogin(int staffID, string password)
        {
            OpenConnection(); //Open Connection

            try
            {
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
            catch (Exception)
            {
                return false; // return false if anything fails
            }

        }
    }
}
