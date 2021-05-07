using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowKey : MonoBehaviour
{
    public GameObject parent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            player.YellowKey++;
            pickups.doUpdate = true;
            Destroy(parent);
        }
    }
}
