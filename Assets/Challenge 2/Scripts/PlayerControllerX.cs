using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canFetch;
    private float initiateFetch = 0.1f;
    public float fetchResetTime = 2;

    void Start()
    {
        InvokeRepeating("AllowFetch", initiateFetch, fetchResetTime);
    }
    void Update()
    {
        // On spacebar press, send the dog to fetch
        if (Input.GetKeyDown(KeyCode.Space) && canFetch)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canFetch = false;
        }
    }

    void AllowFetch()
    {
        canFetch = true;
    }
}
