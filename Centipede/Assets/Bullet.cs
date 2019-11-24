using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody _rb;
    public float dartSpeed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector3(0, dartSpeed, 0);

        if(transform.position.y > 5.20f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Mushroom"))
        {
            other.GetComponent<Mushroom>().GetHit();
            Destroy(gameObject);
        }

        if(other.gameObject.CompareTag("Centipede"))
        {
            other.GetComponent<Centipede>().GetHit();
            Destroy(gameObject);
        }
    }
}
