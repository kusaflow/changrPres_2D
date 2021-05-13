using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public Animator anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            anim.SetTrigger("tri");
            globalV.lastPos_x = transform.position.x;
            globalV.lastPos_y = transform.position.y;
        }
    }
}
