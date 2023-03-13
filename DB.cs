﻿
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom
{
    internal class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=desktop-naopkcl;Initial Catalog=workshop;Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {

                sqlConnection.Close();
            }
        }
            public SqlConnection GetConnection()
            {
                return sqlConnection;
            }
        }
    }

