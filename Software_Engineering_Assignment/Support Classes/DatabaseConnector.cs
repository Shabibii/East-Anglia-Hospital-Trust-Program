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
        private SqlCommand sqlCommand;

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
            sqlCommand = null;
            sqlDataAdapter = null;
            sqlConnection.Close(); //Close SQL connection
        }



        public Patient GetPatient(int bayNumber, int bedNumber)
        {
            OpenConnection(); //Open Connection
            sqlCommand = new SqlCommand(Constants.GetPatient(bedNumber,bayNumber), sqlConnection);

            string[] rawPatientData = new string[11];

            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                if (!dataReader.HasRows) return new Patient() { FirstName = "Empty", Surname = "Record", bedNumber = bedNumber }; //If query result is empty

                if (dataReader.Read())
                {
                    for (int i = 0; i < rawPatientData.Length; i++)
                        rawPatientData[i] = dataReader[i].ToString();
                }
            }

            CloseConnection();
            return new Patient(rawPatientData);
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
            sqlCommand = new SqlCommand(Constants.GetStaff(staffID), sqlConnection);

            string[] rawStaffData = new string[10];

            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                if (!dataReader.HasRows) return null; //If query result is empty

                if (dataReader.Read())
                {
                    for (int i = 0; i < rawStaffData.Length; i++)
                        rawStaffData[i] = dataReader[i].ToString();
                }
            }

            CloseConnection();
            return new Staff(rawStaffData);
        }

        public List<Staff> GetOnCallStaff(string date, bool returnAllStaffAvailableOnDate = false)
        {
            try
            {
                OpenConnection(); //Open Connection
                List<Staff> staffList = new List<Staff>();

                using (DataSet dataSet = new DataSet())
                {
                    string code = returnAllStaffAvailableOnDate ?
                                Constants.GetStaffSchedule(date)
                                : Constants.GetStaffOnCall(date);

                    sqlDataAdapter = new SqlDataAdapter(code, sqlConnection);
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

        public List<Staff> GetUnregisteredStaff(string date, bool returnAllStaffUnregisteredOnDate = false)
        {
            try
            {
                OpenConnection(); //Open Connection
                List<Staff> staffList = new List<Staff>();

                using (DataSet dataSet = new DataSet())
                {
                    string code = returnAllStaffUnregisteredOnDate ?
                                Constants.GetStaffSchedule(date)
                                : Constants.GetStaffUnregistered(date);

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
            if (GetOnCallStaff(date, true).Select(x => x.StaffId).Contains(staffId))
            {
                UpdateStaffschedule(staffId, date, false);
            }
            else
            {
                OpenConnection();
                sqlCommand = new SqlCommand(Constants.RegisterStaff(staffId), sqlConnection);
                sqlCommand.Parameters.AddWithValue("@date", $"{date}");
                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
            
        }

        public void UnregisterStaff(int staffId, string date)
        {
            if (GetUnregisteredStaff(date, false).Select(x => x.StaffId).Contains(staffId))
            {
                UpdateStaffschedule(staffId, date, true);
            }
            else
            {
                OpenConnection();
                sqlCommand = new SqlCommand(Constants.DeregisterStaff(staffId), sqlConnection);
                sqlCommand.Parameters.AddWithValue("@date", $"{date}");
                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
            
        }

        public void UpdateStaffschedule(int staffId, string date, bool deregistered)
        {
            OpenConnection();
            sqlCommand = new SqlCommand(Constants.UpdateStaffRegister(staffId), sqlConnection);
            sqlCommand.Parameters.AddWithValue("@date", $"{date}");
            sqlCommand.Parameters.AddWithValue("@deregistered", $"{deregistered}");
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

      
        public Module GetModule(int moduleID)
        {
            OpenConnection(); //Open Connection
            sqlCommand = new SqlCommand(Constants.GetModules(moduleID), sqlConnection);

            string[] rawModuleData = new string[6];

            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                if (!dataReader.HasRows) return null; //If query result is empty

                if (dataReader.Read())
                {
                    for (int i = 0; i < rawModuleData.Length; i++)
                        rawModuleData[i] = dataReader[i].ToString();
                }
            }

            CloseConnection();
            return new Module(rawModuleData);
        }

        public Bedside GetBedside(int bayNumber, int bedNumber)
        {
            var rawBedsideData = GetBedsideData(bayNumber, bedNumber);

            Bedside bedside =  new Bedside(rawBedsideData);
            bedside.patient = GetPatient(bayNumber, bedNumber);

            if(bedside.patient.FirstName != "Empty" && bedside.patient.Surname != "Record")
            bedside.patient.ConnectToBedside(rawBedsideData);

            return bedside;
        }

        public string[] GetBedsideData(int bayNumber, int bedNumber)
        {
            OpenConnection(); //Open Connection
            sqlCommand = new SqlCommand(Constants.GetBedside(bedNumber, bayNumber), sqlConnection);

            string[] rawBedsideData = new string[7];

            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                if (!dataReader.HasRows) return null; //If query result is empty

                if (dataReader.Read())
                {
                    for (int i = 0; i < rawBedsideData.Length; i++)
                        rawBedsideData[i] = dataReader[i].ToString();
                }
            }

            CloseConnection();
            return rawBedsideData;
        }


        public void RegisterModule(int moduleID, Module module)
        {
            OpenConnection();
            sqlCommand = new SqlCommand(Constants.RegisterModule(moduleID), sqlConnection);
            sqlCommand.Parameters.AddWithValue("@m1", $"{module}");
            sqlCommand.Parameters.AddWithValue("@m2", $"{module.ModuleUnit}");
            sqlCommand.Parameters.AddWithValue("@m3", $"{module.MaxValue}");
            sqlCommand.Parameters.AddWithValue("@m4", $"{module.MinValue}");
            sqlCommand.Parameters.AddWithValue("@m5", $"{module.CurrentValue}");
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void UpdateModule(Module module, bool logEvent = false)
        {
            OpenConnection();
            sqlCommand = new SqlCommand(Constants.UpdateModule(module.moduleID), sqlConnection);
            sqlCommand.Parameters.AddWithValue("@m1", $"{module}");
            sqlCommand.Parameters.AddWithValue("@m2", $"{module.ModuleUnit}");
            sqlCommand.Parameters.AddWithValue("@m3", $"{module.MaxValue}");
            sqlCommand.Parameters.AddWithValue("@m4", $"{module.MinValue}");
            sqlCommand.Parameters.AddWithValue("@m5", $"{module.CurrentValue}");
            sqlCommand.ExecuteNonQuery();
            CloseConnection();

            if(logEvent) Instance.LogEvent($"values changed", "Module", module.moduleID);
        }

        public void LogEvent(string activityDescription, string type, int id)
        {
            OpenConnection();
            sqlCommand = new SqlCommand(Constants.LogEvent(activityDescription,type,id), sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        

        public List<string[]> GetEventLog(bool filterOutStaff = false)
        {
            OpenConnection(); //Open Connection
            List<string[]> output = new List<string[]>();
            sqlCommand = new SqlCommand(Constants.GetAllEventLogs(), sqlConnection);

            string[] eventLog = new string[7];

            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                if (!dataReader.HasRows) return null; //If query result is empty

                while (dataReader.Read())
                {
                    for (int i = 0; i < eventLog.Length; i++)
                    {
                        if (i == 1 && filterOutStaff) break;
                        eventLog[i] = dataReader[i].ToString();
                    }

                    if (filterOutStaff) continue;
                    output.Add(eventLog);
                    eventLog = new string[7];
                }
            }

            CloseConnection();
            return output;
        }
    }
}
