using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // Component References
    public Rigidbody2D rb;

    // Variables
    private float speed;
    private float xScale;
    private float yScale;
    private Vector2 direction;

	void Start ()
    {
        xScale = Random.Range(-0.5f, 0.0f);
        yScale = Random.Range(-0.5f, 0.0f);
        if (xScale >= -0.15f && yScale >= -0.15f)
        {
            rb.mass = 10.0f;
            speed = 10.0f;
            direction = new Vector2(0.0f, -2.0f);
        }
        else
        {
            speed = Random.Range(1.0f, 3.0f);
            direction = new Vector2(Random.Range(-2.0f, 2.0f), Random.Range(0.0f, -2.0f));
        }
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
        rb.AddTorque(speed * 33.3f);
        transform.localScale += new Vector3(xScale, yScale, xScale);
	}
}