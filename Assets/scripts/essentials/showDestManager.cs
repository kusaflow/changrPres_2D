using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showDestManager : MonoBehaviour
{
    public GameObject player;
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        //transform.rotation = Quaternion.Euler(0, 0, CustomGrav.camZRot * -1);
    }
}
