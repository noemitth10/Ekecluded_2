using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeScript : MonoBehaviour
{
    public Text playerLife;
    public Player player;

    public void Update()
    {
        playerLife.text = "Health: " + player.GetComponent<Player>().Life.ToString();
    }
}
