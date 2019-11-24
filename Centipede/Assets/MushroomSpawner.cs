using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    public GameObject Mushroom;
    public GameObject LevelParent;
    GameObject spawnedMushroom;

    private void Start()
    {
        SpawnLevel();
    }

    public void SpawnLevel()
    {
        for(int i = 0; i < 43; i++)
        {
            spawnedMushroom = Instantiate(Mushroom, LevelParent.transform.position, Quaternion.identity);
            spawnedMushroom.transform.SetParent(LevelParent.transform);
            spawnedMushroom.transform.localScale = Vector3.one;

            spawnedMushroom.transform.localPosition = new Vector3(Random.Range(0, 30), Mathf.RoundToInt(30 - i / 2f));



        }
    }
}
