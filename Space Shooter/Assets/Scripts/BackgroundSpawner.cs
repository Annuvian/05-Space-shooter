using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    // Component References
    public GameObject star;
    public GameObject[] planets;

    // Variables
    public bool areStarsSpawned = false;
    public int spawnDelay;
    public float timer = 0;
    private int randomIndex;
    private Vector3 randomPosition;
    public int spawnAmount;
    public int planetSpawnChance;

	void Update ()
    {
        while (!areStarsSpawned)
        {
            for(int i = 0; i < spawnAmount; i++)
            {
                randomPosition = new Vector3(transform.position.x + Random.Range(-9.0f, 9.0f), transform.position.y + Random.Range(-4.0f, 5.0f), 1.0f);
                Instantiate(star, randomPosition, transform.rotation);
            }
            int spawnRoll = (int)Random.Range(1, 101);
            if (spawnRoll <= planetSpawnChance)
            {
                randomIndex = (int)Random.Range(0, planets.Length);
                randomPosition = new Vector3(transform.position.x + Random.Range(-9.0f, 9.0f), transform.position.y + Random.Range(-4.0f, 5.0f), 1.0f);
                Instantiate(planets[randomIndex], randomPosition, transform.rotation);
            }
            areStarsSpawned = true;
        }
        if (areStarsSpawned)
        {
            timer += 1 * Time.deltaTime;
            if (timer >= spawnDelay)
            {
                timer = 0;
                areStarsSpawned = false;
            }
        }
	}
}