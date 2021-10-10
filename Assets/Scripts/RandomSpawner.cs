using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] kotak;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    private Rigidbody2D rb;
    private GameObject ball;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        int randKotak = Random.Range(0, kotak.Length);

        Instantiate(kotak[randKotak], spawnPoints[randSpawnPoint].position, transform.rotation);
    }
}
