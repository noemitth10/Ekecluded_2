using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item
{
    public Player player;
    public GameObject coin;
    public int delay;
    private Vector3 Pos;
    private Transform trans;
    public GameObject manager;
    public CoinPowerUpManager upManager;
    public override void OnTriggerEnter(Collider collider)
    {
        player.GetComponent<Player>().Points++;
        DestroyCoin();
    }

    private void Awake()
    {
        player = FindObjectOfType<Player>();
        Pos = coin.transform.position;
        trans = coin.transform;
        upManager = FindObjectOfType<CoinPowerUpManager>();
    }

    public void DestroyCoin()
    {

        coin.SetActive(false);
        Invoke("Respawn",50);
        //coin.SetActive(true);
    
    }

    void Respawn()
    {
        
        coin.SetActive(true);
       
    }

}
