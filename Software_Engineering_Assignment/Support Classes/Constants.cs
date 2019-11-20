﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment.Support_Classes
{
    class Constants
    {
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

        //Get staff ID using sql query
        public static string GetStaffId => $"SELECT staff_id FROM Staff;";

        public static string GetStaffPassword(int id) => $"SELECT password FROM Staff Where staff_id = {id};";

        //SELECT column1, column2, ...
        //FROM table_name;


    }
}