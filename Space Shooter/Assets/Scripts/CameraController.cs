using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CameraController : MonoBehaviour
{
    // Component References
    public Transform target;
    public int score = 0;
    public Text scoreTxt;

    // Variables

	void Update ()
    {
        Vector3 offset = new Vector3(0.0f, target.position.y + 3.0f, -10.0f);
        transform.position = offset;
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        score += 1;
        scoreTxt.text = Convert.ToString(score);
    }
}