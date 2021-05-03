using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravImpl : MonoBehaviour
{
    public Rigidbody2D m_rb;
    public float gravMul = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        Vector2 gravity = new Vector3(CustomGrav.xG * gravMul, CustomGrav.yG * gravMul);
        m_rb.AddForce(gravity);
    }
}
