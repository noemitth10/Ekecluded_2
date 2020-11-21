using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : Item
{
    private byte time;

    public byte Time
    {
        get { return time; }
        set { time = value; }
    }

}
