using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomGround : MonoBehaviour
{
    public GameObject ground;
    public float spawnInterval = 1f; 
    public float speed = 2f; 

    public float spawnYPosition = -4.2f;

    public float nextSpawnTime;

    public void Start()
    {
        nextSpawnTime = Time.time;
    }

    public void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            Vector3 spawnPosition = new Vector3(15f, -4.2f, transform.position.z);
            GameObject newObject = Instantiate(ground, spawnPosition, Quaternion.identity);
            newObject.GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            nextSpawnTime = Time.time + spawnInterval;
        }
    }
}

