using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackBall : MonoBehaviour
{
    public GameObject Player;
    
    [Range(0.005f, 0.02f)]
    public float dragSpeed;


    public float Speed;
    Vector3 distance;


    private Vector3 lastMousePosition;

    void OnMouseDown()
    {
        lastMousePosition = Input.mousePosition;
    }

    void OnMouseDrag()
    {

        distance = Input.mousePosition - lastMousePosition;
        distance *= 100f;
        Player.GetComponent<PlayerBehaviour>().MoveNew(distance);
        lastMousePosition = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        Player.GetComponent<PlayerBehaviour>().Stop();
        lastMousePosition = Input.mousePosition;
    }

    private void OnMouseExit()
    {
        Player.GetComponent<PlayerBehaviour>().Stop();
    }
}
