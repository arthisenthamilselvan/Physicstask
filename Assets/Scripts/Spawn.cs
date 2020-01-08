using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spwanTime;
    public float spwanDelay;

    public GameObject sphere;

    public float velocity;
    void Start()
    {
        if (stopSpawning) {
           
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(transform.position);
        }
    }
    public void SpawnObject() {
        Instantiate(spawnee,transform.position,transform.rotation);

    }
}
