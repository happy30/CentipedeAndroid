using UnityEngine;
using System.Collections;

public class DragRotator : MonoBehaviour
{


    private float _sensitivity;
    private Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private bool _isRotating;


    private float XaxisRotation;
    private float YaxisRotation;

    private bool MouseDown;

    void Start()
    {
        _sensitivity = 0.15f;
    }

    void OnMouseDrag()
    {
       

        XaxisRotation = Input.GetAxis("Mouse X") * _sensitivity;
        YaxisRotation = Input.GetAxis("Mouse Y") * _sensitivity;

        transform.RotateAround(Vector3.down, XaxisRotation);
        transform.RotateAround(Vector3.right, YaxisRotation);
    }

}