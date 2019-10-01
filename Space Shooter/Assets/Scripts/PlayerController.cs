using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Component References
    public Rigidbody2D rb;
    public Transform height;
    public GameObject quitButton;
    public GameObject restartButton;
    public GameObject gameOverText;
    public GameObject pauseButton;
    // Variables
    public float thrustSpeed;
    public float moveSpeed;
    public int health;
    public bool isSlowed = false;
    private float timer;

	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * moveSpeed, thrustSpeed);

        if (health <= 0)
        {
            Time.timeScale = 0;
            quitButton.SetActive(true);
            restartButton.SetActive(true);
            gameOverText.SetActive(true);
            pauseButton.SetActive(false);
        }

        if (isSlowed)
        {
            timer += 1 * Time.deltaTime;
            if (timer >= 10.0f)
            {
                moveSpeed = 10;
                isSlowed = false;
                timer = 0.0f;
            }
        }
        if (Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            health -= 10;
        }
        if (collision.gameObject.tag == "Oxygen")
        {
            health += 20;
            if (health > 100)
            {
                health = 100;
            }
            Destroy(collision.gameObject);
        }
    }

    void Slow()
    {
        moveSpeed = 5.0f;
        isSlowed = true;
    }
}