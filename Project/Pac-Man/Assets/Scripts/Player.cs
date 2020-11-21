using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private byte life;

    public byte Life
    {
        get { return life; }
        set { life = value; }
    }

    private uint points;

    public uint Points
    {
        get { return points; }
        set { points = value; }
    }


}
