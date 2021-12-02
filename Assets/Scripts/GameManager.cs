using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;

    private SpawnManager spawnManager;

    private void Start()
    {
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }

    public void Addlives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            lives = 0;
            Debug.Log("Game Over!");
            spawnManager.CancelInvoke("SpawnRandomAnimal");
        }

        Debug.Log("Lives = " + lives);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score =" + score);
    }
}
