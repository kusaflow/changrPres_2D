using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowLock : MonoBehaviour
{

    public Animator anim; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (player.YellowKey > 0)
            {
                player.YellowKey--;
                pickups.doUpdate = true;
                if (anim)
                    anim.SetTrigger("isDestroy");
            }
        }
    }
}
