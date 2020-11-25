using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    void Awake()
    {
        Invoke("DoorDisable", 5);
    }

    private void DoorDisable()
    {
       door.SetActive(true);
    }
}
