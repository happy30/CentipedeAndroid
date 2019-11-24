using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public bool Shooting;

    public GameObject Dart;

    GameObject spawnedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Shooting)
        {
            if(spawnedObject == null)
            {
                Stats.Shots++;
                spawnedObject = (GameObject)Instantiate(Dart, new Vector3(transform.position.x, transform.position.y + 0.31f, transform.position.z), Quaternion.identity);
            }
        }
    }
}
