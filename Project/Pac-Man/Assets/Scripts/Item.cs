using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    private byte val;

    public byte Val
    {
        get { return val; }
        set { val = value; }
    }

    public abstract void OnTriggerEnter(Collider collider);
}
