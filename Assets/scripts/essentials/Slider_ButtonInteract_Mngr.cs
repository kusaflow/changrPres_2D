using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Slider_ButtonInteract_Mngr : MonoBehaviour
{
    public Button UpBut;
    public Button DownBut;

    public Scrollbar slider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        if (slider.value >= 1f)
        {
            UpBut.interactable = true;
        }
        else
        {
            UpBut.interactable = false;
        }


        if (slider.value <= 0)
        {
            DownBut.interactable = true;
        }
        else
        {
            DownBut.interactable = false;

        }

    }
}
