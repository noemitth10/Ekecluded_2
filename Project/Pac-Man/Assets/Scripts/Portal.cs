using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Teleport teleport;
    public GameObject player;
    public GameObject teleportTo;
    private void OnTriggerEnter(Collider other)
    {
        if (Teleport.canTp)
        {
                Teleport.canTp = false;
                player.transform.position = new Vector3(teleportTo.transform.position.x, teleportTo.transform.position.y + 2.5f, teleportTo.transform.position.z);
                Invoke("EnableTp", 3);
           


        }
    }
    public void EnableTp()
    {
        Teleport.canTp = true;
    }
}
