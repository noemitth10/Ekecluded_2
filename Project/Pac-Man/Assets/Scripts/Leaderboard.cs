using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    private int id;
    private string playerName;
    private int score;

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

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

    public Leaderboard(int id, string playerName, int score)
    {
        this.Id = id;
        this.PlayerName = playerName;
        this.Score = score;
    }

    public Leaderboard()
    {

    }

    public override string ToString()
    {
        string row = string.Format("Player: {0} Score: {1}", PlayerName, Score);

        return row;
    }
}
