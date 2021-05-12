using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public Animator anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetTrigger("lvlD");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
