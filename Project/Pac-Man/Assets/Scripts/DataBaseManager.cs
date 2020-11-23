using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oracle.ManagedDataAccess.Client;
using System.Data;

public class DataBaseManager : MonoBehaviour
{
    class OracleDatabaseConnection
    {
        public OracleConnection GetConnection()
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=EB6SAR;Password=EKE2020;";

            return connection;
        }
    }

    class Leaderboard
    {
        private string playerName;
        private int score;

        public string PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        public Leaderboard(string playerName, int score)
        {
            this.PlayerName = playerName;
            this.Score = score;
        }

        public Leaderboard()
        {

        }

        public override string ToString()
        {
            return playerName;
        }
    }

    class LeaderboardManagement : OracleDatabaseConnection
    {
        public List<Leaderboard> Select()
        {
            List<Leaderboard> toplista = new List<Leaderboard>();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT playerName,score FROM leaderboard ORDER BY score LIMIT 10";

            OracleConnection connection = GetConnection();
            connection.Open();

            command.Connection = connection;

            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Leaderboard leaderboard = new Leaderboard();
                leaderboard.PlayerName = reader["name"].ToString();
                leaderboard.Score = int.Parse(reader["score"].ToString());

                toplista.Add(leaderboard);
            }
            connection.Close();

            return toplista;
        }

        public int Insert(Leaderboard toplista)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO city VALUES(:playerName, :score)";

            OracleParameter p_playerName = new OracleParameter()
            {
                ParameterName = ":playerName",
                Direction = ParameterDirection.Input,
                DbType = DbType.String,
                Value = toplista.PlayerName
            };

            command.Parameters.Add(p_playerName);

            OracleParameter p_score = new OracleParameter()
            {
                ParameterName = ":score",
                Direction = ParameterDirection.Input,
                DbType = DbType.Int32,
                Value = toplista.Score
            };

            command.Parameters.Add(p_score);

            OracleConnection connection = GetConnection();
            connection.Open();
            command.Connection = connection;

            return command.ExecuteNonQuery();
        }
    }
}
