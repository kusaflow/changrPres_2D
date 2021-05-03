using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomGrav : MonoBehaviour
{

    public static float gravVal = -9.81f;
    public static float camZRot = 0;

    public static float LS_inc = 0;
    public static float RS_inc = 0;


    public Scrollbar scroll_R;
    public Scrollbar scroll_L;

    public static float xG = 0;
    public static float yG = 0;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    void FixedUpdate()
    {

        camZRot = 180 * (scroll_R.value * -1) + 180 * scroll_L.value + LS_inc * 180 + RS_inc * 180;

        //Debug.Log(camZRot);

        yG = Mathf.Cos(Mathf.Deg2Rad * camZRot) * gravVal;
        xG = Mathf.Sin(Mathf.Deg2Rad * camZRot) * gravVal * -1;

    }
}
