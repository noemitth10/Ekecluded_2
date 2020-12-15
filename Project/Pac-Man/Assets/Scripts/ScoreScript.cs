using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text playerScore;
    public Player player;
    
    public void Update()
    {
        playerScore.text = "Score: " + player.GetComponent<Player>().Points.ToString();
    }
}
