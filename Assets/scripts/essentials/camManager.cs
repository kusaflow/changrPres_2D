using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camManager : MonoBehaviour
{
    public Camera cam;
    public GameObject player;

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        cam.transform.rotation = Quaternion.Euler(0, 0, CustomGrav.camZRot);

        cam.orthographicSize = slider.value;
    }
}
