using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oracle.ManagedDataAccess.Client;

public class DatabaseConnection : MonoBehaviour
{
    public static OracleConnection GetConnection()
    {
        OracleConnection connection = new OracleConnection();
        connection.ConnectionString = @"Data Source=193.225.33.71;User Id=EB6SAR;Password=EKE2020;";

        return connection;
    }
}
