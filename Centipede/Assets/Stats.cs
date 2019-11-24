using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stats : MonoBehaviour
{

    private void Start()
    {
        Shots = 0;
        MushroomHits = 0;
        MushroomDestroyed = 0;
    }

    public static int Shots;
    public static int MushroomHits;
    public static int MushroomDestroyed;
    public static int CentipedeHeadsShot;
    public static int CentipedeBodiesShot;

    public static int Score;
}
