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



        public Patient GetPatient(int bayNumber, int bedNumber)
        {
            try
            {
                OpenConnection(); //Open Connection
                Patient patient;

                using (DataSet dataSet = new DataSet())
                {
                    sqlDataAdapter = new SqlDataAdapter(Constants.GetPatient(bedNumber,bayNumber), sqlConnection);
                    sqlDataAdapter.Fill(dataSet); //Copy Data From dataset to Staff Object and return it

                    List<string> rawPatientData = new List<string>();

                    DataTable staffTable = dataSet.Tables[0];
                    DataRow row = staffTable.Rows[0];

                    foreach (DataColumn column in staffTable.Columns)
                    {
                        rawPatientData.Add(row[column].ToString());
                    }

                    patient = new Patient(rawPatientData);
                }

                CloseConnection(); //Close Connection

                return patient;

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
                SqlCommand sqlCommand = new SqlCommand(Constants.RegisterStaff(staffId), sqlConnection);
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
                SqlCommand sqlCommand = new SqlCommand(Constants.DeregisterStaff(staffId), sqlConnection);
                sqlCommand.Parameters.AddWithValue("@date", $"{date}");
                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
            
        }

        public void UpdateStaffschedule(int staffId, string date, bool deregistered)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(Constants.updateStaffRegister(staffId), sqlConnection);
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
            try
            {
                Module module = null;

                using (DataSet dataSet = new DataSet())
                {
                    sqlDataAdapter = new SqlDataAdapter(Constants.GetModules(moduleID), sqlConnection);
                    sqlDataAdapter.Fill(dataSet); //Copy Data From dataset to Staff Object and return it

                    List<string> rawModuleData = new List<string>();

                    DataTable moduleTable = dataSet.Tables[0];
                    if (moduleTable.Rows.Count < 1) goto endOrReturn;
                    DataRow row = moduleTable.Rows[0];

                    foreach (DataColumn column in moduleTable.Columns)
                    {
                        rawModuleData.Add(row[column].ToString());
                    }

                    module = new Module(rawModuleData);
                }

                endOrReturn:;
                CloseConnection(); //Close Connection

               
                return module;
            }
            catch (Exception)
            {
                CloseConnection(); //Close Connection
                return null;
            }
        }

        public Bedside GetBedside(int bayNumber, int bedNumber)
        {
            OpenConnection(); //Open Connection
            try
            {
                Bedside bedside = null;

                using (DataSet dataSet = new DataSet())
                {
                    sqlDataAdapter = new SqlDataAdapter(Constants.GetBedside(bedNumber, bayNumber), sqlConnection);
                    sqlDataAdapter.Fill(dataSet); //Copy Data From dataset to Staff Object and return it

                    List<string> rawBedsideData = new List<string>();

                    DataTable bedsideTable = dataSet.Tables[0];
                    if (bedsideTable.Rows.Count < 1) goto endOrReturn;
                    DataRow row = bedsideTable.Rows[0];

                    foreach (DataColumn column in bedsideTable.Columns)
                    {
                        rawBedsideData.Add(row[column].ToString());
                    }

                    bedside = new Bedside(rawBedsideData);
                }

                endOrReturn:;
                CloseConnection(); //Close Connection


                return bedside;
            }
            catch (Exception)
            {
                CloseConnection(); //Close Connection
                return null;
            }
        }


        public void RegisterModule(int moduleID, Module module)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(Constants.RegisterModule(moduleID), sqlConnection);
            sqlCommand.Parameters.AddWithValue("@m1", $"{module}");
            sqlCommand.Parameters.AddWithValue("@m2", $"{module.ModuleUnit}");
            sqlCommand.Parameters.AddWithValue("@m3", $"{module.MaxValue}");
            sqlCommand.Parameters.AddWithValue("@m4", $"{module.MinValue}");
            sqlCommand.Parameters.AddWithValue("@m5", $"{module.CurrentValue}");
            sqlCommand.ExecuteNonQuery();
            CloseConnection();


        }

        public void UpdateModule(Module module)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(Constants.UpdateModule(module.moduleID), sqlConnection);
            sqlCommand.Parameters.AddWithValue("@m1", $"{module}");
            sqlCommand.Parameters.AddWithValue("@m2", $"{module.ModuleUnit}");
            sqlCommand.Parameters.AddWithValue("@m3", $"{module.MaxValue}");
            sqlCommand.Parameters.AddWithValue("@m4", $"{module.MinValue}");
            sqlCommand.Parameters.AddWithValue("@m5", $"{module.CurrentValue}");
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
