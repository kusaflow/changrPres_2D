using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickups : MonoBehaviour
{
    public static bool doUpdate;
    public GameObject yellowKey_Pref;

    Queue<GameObject> picks = new Queue<GameObject>();


    // Update is called once per frame
    void Update()
    {
        if (doUpdate)
        {
            ManageReupload();
            doUpdate = false;
        }
    }

    private void ManageReupload ()
    {
        DeleteAll();
        uploadAll();
    }

    private void DeleteAll()
    {
        while(picks.Count > 0)
        {
            Destroy(picks.Dequeue());
        }
    }

    private void uploadAll()
    {
        for (int i =0; i<player.YellowKey; i++)
        {
            GameObject go = Instantiate(yellowKey_Pref, transform);
            picks.Enqueue(go);
        }
    }

}
