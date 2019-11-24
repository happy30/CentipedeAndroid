using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    Vector3 deltaPos;
    public float Speed;

    private Rigidbody _rb;

    RaycastHit hit;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        deltaPos = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (deltaPos.x < -5.1f) deltaPos = new Vector3(-5.1f, transform.position.y, transform.position.z); _rb.velocity = Vector3.zero; deltaPos = transform.position;
        if (deltaPos.x > 5.1f) deltaPos = new Vector3(5.1f, transform.position.y, transform.position.z); _rb.velocity = Vector3.zero; deltaPos = transform.position;

        if (deltaPos.y < -4.83f) deltaPos = new Vector3(transform.position.x, -4.83f, transform.position.z); _rb.velocity = Vector3.zero; deltaPos = transform.position;
        if (deltaPos.y > -3.2f) deltaPos = new Vector3(transform.position.x, -3.2f, transform.position.z); _rb.velocity = Vector3.zero; deltaPos = transform.position;

        _rb.MovePosition(deltaPos);
        */

        _rb.velocity = deltaPos;
   

    }

    public void MoveNew(Vector3 delPos)
    {
        delPos *= 0.01f;
        deltaPos = delPos;
    }

    public void Stop()
    {
        _rb.velocity = Vector3.zero;
        deltaPos = Vector3.zero;
    }
}
