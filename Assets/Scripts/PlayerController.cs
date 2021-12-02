using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement Variables
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10;

    //Movement Boundary Variables
    public float xRange = 10;
    public float zRangeTop = 15;
    public float zRangeBottom = 8;

    //Projectile Setting Variables
    public GameObject projectile;
    public Transform projectileSpawnPoint;

    void Update()
    {
        ShootProjectile();

        StayInBounds();        

        Movement();
    }

    void ShootProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, projectileSpawnPoint.position, projectile.transform.rotation);
        }
    }

    void StayInBounds()
    {
        //Horizontal boundary
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Vertical Boundary
        if (transform.position.z < -zRangeBottom)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRangeBottom);
        }
        if (transform.position.z > zRangeTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        }
    }

    void Movement()
    {
        //Move Horizontally
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //Move Vertically
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
    }
}
