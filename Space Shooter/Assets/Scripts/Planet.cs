using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    // Component References
    public Rigidbody2D rb;

    // Variables
    public float maxSizeIncrease;
    public float upwardSpeed;

    void Start ()
    {
        float scale = Random.Range(0.0f, maxSizeIncrease);
        float rotation = Random.Range(0.0f, 360.0f);
        transform.localScale += new Vector3(scale, scale, scale);
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotation);
        rb.velocity = new Vector2(0.0f, upwardSpeed);
    }
}