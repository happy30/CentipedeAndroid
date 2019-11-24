using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackBall : MonoBehaviour
{
    public GameObject Player;
    public Camera mainCamera;
    
    [Range(0.005f, 0.02f)]
    public float dragSpeed;


    public float Speed;
    Vector3 distance;


    private Vector3 lastMousePosition;


    private void Update()
    {
        if (Input.touchCount == 0) return;

        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.touches[i];
            Ray touchRay = mainCamera.ScreenPointToRay(touch.position);
            RaycastHit[] hits = Physics.RaycastAll(touchRay);
            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.gameObject.CompareTag("Controller"))
                {
                    //found controller
                    Vector2 deltaRot = Input.touches[i].deltaPosition;
                    Player.GetComponent<PlayerBehaviour>().MoveNew(deltaRot * 33);

                    if (Input.touches[i].phase == TouchPhase.Ended)
                    {
                        deltaRot = Vector2.zero;
                        Player.GetComponent<PlayerBehaviour>().MoveNew(deltaRot);
                    }
                }
            }
        }
    }

    /*

    void OnMouseDown()
    {
        lastMousePosition = Input.mousePosition;
    }

    void OnMouseDrag()
    {

        distance = Input.mousePosition - lastMousePosition;
        distance *= 100f;
        
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
    */
}
