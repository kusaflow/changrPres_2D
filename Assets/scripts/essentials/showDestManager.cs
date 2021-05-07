using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showDestManager : MonoBehaviour
{
    public GameObject player;
    public float angle;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
