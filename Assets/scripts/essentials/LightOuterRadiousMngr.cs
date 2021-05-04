using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

public class LightOuterRadiousMngr : MonoBehaviour
{

    public Light2D lt;
    public Slider slider;
    // Update is called once per frame
    void Update()
    {
        //if (slider.value >= 7)
            lt.pointLightOuterRadius = slider.value*1.5f;
        //else
            //light.pointLightOuterRadius = 7;
    }
}
