﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BlogWeb.Classes
{
    public class SqlConnectClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=RESUL-THINKPAD\\SQLEXPRESS02;Initial Catalog=BlogWeb;Integrated Security=True");
        public static void checkconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }


}