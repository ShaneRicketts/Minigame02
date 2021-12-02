using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    //Top Spawn Variables
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;

    //Side Spawn Variables
    public float sideSpawnRangeZMax;
    public float sideSpawnRangeZMin;
    public float sideSpawnRangeX;

    //Spawn Timer Variables
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        SpawnTopAnimal();
        SpawnLeftAnimal();
        SpawnRightAnimal();
    }
    
    void SpawnLeftAnimal()
    {
        //randomly generate animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //randomly generate spawn position
        Vector3 spawnPos = new Vector3(sideSpawnRangeX, 0, Random.Range(sideSpawnRangeZMin,sideSpawnRangeZMax));
        Vector3 rotateLeft = new Vector3(0, -90, 0);
        
        //Spawn chosen Animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotateLeft));
    }

    void SpawnRightAnimal()
    {
        //randomly generate animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //randomly generate spawn position
        Vector3 spawnPos = new Vector3(-sideSpawnRangeX, 0, Random.Range(sideSpawnRangeZMin,sideSpawnRangeZMax));
        Vector3 rotateRight = new Vector3(0, 90, 0);
        
        //Spawn chosen Animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotateRight));
    }
    
    void SpawnTopAnimal()
    {
        //randomly generate animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //random generate spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        //Spawn chosen animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
