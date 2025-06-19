using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedSpawner : MonoBehaviour
{
    public GameObject seedPrefab; // 
    public Transform spawnArea; // 
    public int seedCount = 2000; // numbrt

    void Start()
    {
        for (int i = 0; i < seedCount; i++)
        {
            SpawnSeed();
        }
    }

    void SpawnSeed()
    {
        // generate seed
        Vector3 randomPosition = new Vector3(
            spawnArea.position.x + Random.Range(-300f, 300f), // X move
            spawnArea.position.y + Random.Range(200f, 5f),  // Y different hight
            spawnArea.position.z + Random.Range(-300f, 300f)  // Z move
        );

        GameObject seed = Instantiate(seedPrefab, randomPosition, Quaternion.identity);

        // affective by wind
        Rigidbody rb = seed.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // start from an angle
            Vector3 initialVelocity = new Vector3(Random.Range(-3f, 40f), -1f, Random.Range(-2f, 2f));
            rb.velocity = initialVelocity;

            // constantly change x and 
            Vector3 windForce = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
            rb.AddForce(windForce * 3f, ForceMode.Impulse);

            // rotation 
            Vector3 randomTorque = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), Random.Range(-2f, 2f));
            rb.AddTorque(randomTorque, ForceMode.Impulse);
        }
    }
}