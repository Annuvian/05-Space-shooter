using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Component References
    public GameObject[] aliens;
    public GameObject asteroid;

    // Variables
    public bool isSpawned = false;
    public float spawnDelay;
    public float timer = 0;
    private int randomIndex;
    public int alienSpawnChance;
    private int spawnNumber;

    private void Start()
    {
        spawnDelay = Random.Range(1.5f, 3.0f);
    }

    void Update ()
    {
        if (!isSpawned)
        {
            spawnNumber = (int)Random.Range(1, 101);
            if (spawnNumber <= alienSpawnChance)
            {
                randomIndex = (int)Random.Range(0, aliens.Length);
                Instantiate(aliens[randomIndex], transform.position, transform.rotation);
            }
            else
            {
                Instantiate(asteroid, transform.position, transform.rotation);
            }
            isSpawned = true;
            }
        if (isSpawned)
        {
            timer += 1 * Time.deltaTime;
            if (timer >= spawnDelay)
            {
                timer = 0;
                isSpawned = false;
                spawnDelay = Random.Range(1.5f, 3.0f);
            }
        }
	}
}