﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client; 

namespace DAL
{
    public class ConnectionManager
    {
       
        internal OracleConnection _conexion;
        public ConnectionManager(string connectionString)
        {

            _conexion = new OracleConnection(connectionString);

        }


        public void Open()
        {
            _conexion.Open();
        }

        public void Close()
        {
            _conexion.Close();
        }


    }
}
