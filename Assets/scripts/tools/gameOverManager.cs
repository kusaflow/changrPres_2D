using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverManager : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D player;

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("b_go", globalV.gameOver);
        if (globalV.gameOver)
        {
            anim.SetTrigger("gameOver");
            player.bodyType = RigidbodyType2D.Static;
        }
        else{
            player.bodyType = RigidbodyType2D.Dynamic;
            anim.SetTrigger("gotoCheckPoint");
        }

    }


}
