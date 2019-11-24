using UnityEngine;
using System.Collections;

public class DragRotator : MonoBehaviour
{


    private float _sensitivity;
    private Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private bool _isRotating;

    public Camera mainCamera;


    private float XaxisRotation;
    private float YaxisRotation;

    private bool MouseDown;

    void Start()
    {
        _sensitivity = 0.008f;
    }

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
                    Vector2 deltaRot = Input.touches[i].deltaPosition * _sensitivity;

                    transform.RotateAround(Vector3.down, deltaRot.x);
                    transform.RotateAround(Vector3.right, deltaRot.y);


                }
            }
        }
    }

        /*
    void OnMouseDrag()
    {
       

        XaxisRotation = Input.GetAxis("Mouse X") * _sensitivity;
        YaxisRotation = Input.GetAxis("Mouse Y") * _sensitivity;

        
    }
    */

}