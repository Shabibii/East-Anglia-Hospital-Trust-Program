using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment.Support_Classes
{
    static class Constants
    {

        private static Random random;

        public static int NextRandomValue
        {
            get
            {
                lock (random)
                {
                    if (random == null)
                        random = new Random();

                    return random.Next(0, 10);
                }
                
            }
        }

        //These are sql queries that will be used regurally

        public static string GetAllEventLogs(int bayNo) =>
            $@"SELECT * FROM 'Log/Activity'";

        public static string GetPatientsFromBay(int bayNo) =>
            $@"SELECT *
                FROM Patient 
                Where bay_id = {bayNo};";

        public static string GetStaff(int id) =>
            $@"SELECT staff_id, first_name, last_name, staff_type, date_of_birth, gender, contact_no_1, contact_no_2, email, address
                FROM Staff 
                Where staff_id = {id};";

        public static string GetStaffOnCall(string date)
        => $@"SELECT staff_id
                FROM StaffSchedule
                WHERE oncall_date = '{date}'";

        public static string GetStaffUnregistered(string date)
        => $@"SELECT staff_id
                FROM StaffSchedule
                WHERE oncall_date = '{date}' AND deregistered = 'true'";


        public static string RegisterStaff(int staffId)
        => $@"INSERT INTO StaffSchedule VALUES ({staffId},@date,0)";

        public static string UnregisterStaff(int staffId)
        => $@"UPDATE StaffSchedule
                SET oncall_date = @date, deregistered = @deregistered
                WHERE staff_Id = {staffId}";


        //Get staff ID using sql query
        public static string GetStaffId => $"SELECT staff_id FROM Staff;";

        public static string GetStaffPassword(int id) => $"SELECT password FROM Staff Where staff_id = {id};";


        public static string GetModule(int moduleNumber, int bedsideNo) => $"SELECT module_id_{moduleNumber} FROM Bedside Where bedside_no = {bedsideNo};";
        //SELECT column1, column2, ...
        //FROM table_name;


    }
}
