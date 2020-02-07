using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerUp;

    private float xSpawnRange = 3.5f;
    private float ySpawm = 0.25f;
    private float zSpawm = 4.5f;
    private float zPowerup = 3.0f;

    private float timeEnemies = 1.0f;
    private float timePowerup = 5.0f;
    private float startDelay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating( "SpawnEnemis", startDelay, timeEnemies);
        InvokeRepeating("SpawnPowerup", startDelay, timePowerup);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemis()
    {
        float enemyRandom = Random.Range(-xSpawnRange,xSpawnRange);
        int enemyIndex = Random.Range(0,enemies.Length);
        Vector3 spawmPos = new Vector3(enemyRandom,ySpawm,zSpawm);
        Instantiate(enemies[enemyIndex],spawmPos,enemies[enemyIndex].gameObject.transform.rotation);
    }
    void SpawnPowerup()
    {
        float enemyRandom = Random.Range(-xSpawnRange, xSpawnRange);
        float zPower = Random.Range(-zPowerup, zPowerup);
        Vector3 spawnPos = new Vector3(enemyRandom, 0.2f, zPower);
        Instantiate(powerUp, spawnPos, powerUp.gameObject.transform.rotation);

    }
}
