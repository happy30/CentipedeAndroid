using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentipedeSpawner : MonoBehaviour
{
    public GameObject CentipedeFull;
    GameObject spawnedCentipede;
    public Transform Parent;



    void Start()
    {
        SpawnCentipede();
    }

    void SpawnCentipede()
    {
        spawnedCentipede = (GameObject)Instantiate(CentipedeFull, Parent.position, Quaternion.identity);
        spawnedCentipede.transform.SetParent(Parent);
        spawnedCentipede.transform.localScale = Vector3.one;
    }

    private void Update()
    { 
    
        //STINKY CODE STINKY CODE BUT IT IS 12AM
        if(GameObject.FindGameObjectsWithTag("Centipede").Length == 0)
        {
            SpawnCentipede();
        }
    }
}
