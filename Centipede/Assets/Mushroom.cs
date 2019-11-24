using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public Material Mush4;
    public Material Mush3;
    public Material Mush2;
    public Material Mush1;

    int health = 4;

    Renderer _rend;

    // Start is called before the first frame update
    void Start()
    {
        _rend = GetComponent<Renderer>();
    }



    public void GetHit()
    {
        health--;
        Stats.MushroomHits++;

        switch (health)
        {
            case 3:
                _rend.material = Mush3;
                break;

            case 2:
                _rend.material = Mush2;
                break;

            case 1:
                _rend.material = Mush1;
                break;

            case 0:
                Stats.MushroomDestroyed++;
                Stats.Score++;
                Destroy(gameObject);
                break;

        }
    }
}
