using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
        }
    }
}
