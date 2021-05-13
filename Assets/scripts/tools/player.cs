using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static int YellowKey = 0;
    public int lvl = 0;

    player()
    {
        globalV.CurrLvl = lvl;
    }

    private void Start()
    {
        YellowKey = 0;

        
        globalV.lastPos_x = transform.position.x;
        globalV.lastPos_y = transform.position.y;
    }
}
