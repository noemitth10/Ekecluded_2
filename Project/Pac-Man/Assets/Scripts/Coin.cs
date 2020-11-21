using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item
{
    public GameObject player;
    public override void OnTriggerEnter(Collider collider)
    {
        player.GetComponent<Player>().Points++;
    }
}
