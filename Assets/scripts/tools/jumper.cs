using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    public float forceVal = 1000;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        float Angle = transform.rotation.eulerAngles.z;
        
        float yG = Mathf.Cos(Mathf.Deg2Rad * Angle) * forceVal;
        float xG = Mathf.Sin(Mathf.Deg2Rad * Angle) * forceVal * -1;

        Vector2 finalF = new Vector3(xG, yG);

        if (collision.rigidbody)
            collision.rigidbody.AddForce(finalF);
        
    }
}
