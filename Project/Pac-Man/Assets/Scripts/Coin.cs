using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item
{
    public Player player;
    public GameObject coin;
    public int delay;
    private Vector3 Pos;

    public override void OnTriggerEnter(Collider collider)
    {
        player.GetComponent<Player>().Points++;
        DestroyCoin();
    }

    private void Awake()
    {
        player = FindObjectOfType<Player>();
        Pos = coin.transform.position;
    }

    public void DestroyCoin()
    {
        StartCoroutine(Respawn());
        //coin.SetActive(true);
        //Debug.Log("FASZ2");
    }

    IEnumerator Respawn()
    {
        coin.SetActive(false);
        yield return new WaitForSeconds(delay);
        coin.SetActive(true);
        //Instantiate(coin, Pos, Quaternion.identity);
        Debug.Log("FASZ");
    }
}
