using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //random generate spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

            //randomly generate animal index
            int animalIndex = Random.Range(0, animalPrefabs.Length);

            Instantiate(animalPrefabs[animalIndex], spawnPos,animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
