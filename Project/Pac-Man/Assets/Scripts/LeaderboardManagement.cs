using Oracle.ManagedDataAccess.Client;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class LeaderboardManagement : MonoBehaviour
{
    public static List<Leaderboard> Select()
    {
        List<Leaderboard> toplista = new List<Leaderboard>();
        OracleCommand command = new OracleCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT * FROM (SELECT playerName,score FROM leaderboard ORDER BY score DESC) WHERE ROWNUM <= 10";

        OracleConnection connection = DatabaseConnection.GetConnection();
        connection.Open();

        command.Connection = connection;

        OracleDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.PlayerName = reader["playerName"].ToString();
            leaderboard.Score = int.Parse(reader["score"].ToString());

            toplista.Add(leaderboard);
            Debug.Log(leaderboard);
        }
        connection.Close();

        return toplista;
    }

    public int SelectId()
    {
        int biggest;
        OracleCommand command = new OracleCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT * FROM (SELECT id FROM leaderboard ORDER BY id DESC) WHERE ROWNUM <= 1";

        OracleConnection connection = DatabaseConnection.GetConnection();
        connection.Open();

        biggest = command.ExecuteNonQuery();

        connection.Close();

        return biggest + 1;
    }

    public int Insert(Leaderboard pontszam)
    {
        int biggest = SelectId();
        OracleCommand command = new OracleCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "INSERT INTO leaderboard VALUES(:id, :playerName, :score)";

        OracleParameter p_id = new OracleParameter()
        {
            ParameterName = ":id",
            Direction = ParameterDirection.Input,
            Value = biggest
        };

        OracleParameter p_playerName = new OracleParameter()
        {
            ParameterName = ":playerName",
            Direction = ParameterDirection.Input,
            DbType = DbType.String,
            Value = pontszam.PlayerName
        };

        command.Parameters.Add(p_playerName);

        OracleParameter p_score = new OracleParameter()
        {
            ParameterName = ":score",
            Direction = ParameterDirection.Input,
            DbType = DbType.Int32,
            Value = pontszam.Score
        };

        command.Parameters.Add(p_score);

        Debug.LogFormat("Playername: {0} , Score: {1}", p_playerName, p_score);

        OracleConnection connection = DatabaseConnection.GetConnection();
        connection.Open();
        command.Connection = connection;

        return command.ExecuteNonQuery();
    }
}
