using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camRotManager : MonoBehaviour
{
    public Scrollbar scroll;

    public bool isInRight = true;

    public void OnClick()
    {
        if (scroll)
        {
            if (scroll.value >= .9)
            {
                if (isInRight)
                    CustomGrav.RS_inc++;
                else
                    CustomGrav.LS_inc++;

                scroll.value = 0;
            }
            else if (scroll.value <= .1)
            {
                if (isInRight)
                    CustomGrav.RS_inc++;
                else
                    CustomGrav.LS_inc++;

                scroll.value = 1;
            }
        }
    }
}
