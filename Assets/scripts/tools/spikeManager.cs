using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            globalV.gameOver = true;
            //Time.timeScale = 0;
        }
    }
}
