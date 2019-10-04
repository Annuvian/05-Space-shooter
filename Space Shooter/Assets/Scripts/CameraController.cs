using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CameraController : MonoBehaviour
{
    // Component References
    public int score = 0;
    public Text scoreTxt;
    public Rigidbody2D rb;

    // Variables
    public float verticalThrust;

	void Update ()
    {
        rb.velocity = new Vector2(0, verticalThrust);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        score += 1;
        scoreTxt.text = Convert.ToString(score);
    }
}